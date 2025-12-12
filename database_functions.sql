-- =============================================
-- Database Functions untuk Developer Performance Tracker
-- =============================================

-- Function 1: Hitung Skor Developer
-- Menghitung skor berdasarkan status kontrak, fitur selesai, dan jumlah bug
CREATE OR REPLACE FUNCTION hitung_skor_developer(
    p_status_kontrak VARCHAR,
    p_fitur_selesai INT,
    p_jumlah_bug INT
)
RETURNS INT AS $$
DECLARE
    v_skor NUMERIC;
    v_result INT;
BEGIN
    -- Untuk Fulltime: Skor = (10 × Fitur) - (5 × Bug)
    IF LOWER(p_status_kontrak) = 'fulltime' THEN
        v_skor := (10 * p_fitur_selesai) - (5 * p_jumlah_bug);
        IF v_skor < 0 THEN
            v_result := 0;
        ELSE
            v_result := v_skor;
        END IF;
    
    -- Untuk Freelance: Skor = 100 × (1 - ((2 × Bug) / (3 × Fitur)))
    ELSE
        IF p_fitur_selesai = 0 THEN
            v_result := 0;
        ELSE
            v_skor := 100 * (1 - ((2.0 * p_jumlah_bug) / (3.0 * p_fitur_selesai)));
            IF v_skor < 0 THEN
                v_result := 0;
            ELSE
                v_result := ROUND(v_skor);
            END IF;
        END IF;
    END IF;
    
    RETURN v_result;
END;
$$ LANGUAGE plpgsql;

-- Function 2: Hitung Total Gaji Developer
-- Menghitung total gaji berdasarkan status kontrak dan skor
CREATE OR REPLACE FUNCTION hitung_gaji_developer(
    p_status_kontrak VARCHAR,
    p_fitur_selesai INT,
    p_jumlah_bug INT
)
RETURNS NUMERIC AS $$
DECLARE
    v_skor INT;
    v_gaji NUMERIC;
BEGIN
    -- Dapatkan skor terlebih dahulu
    v_skor := hitung_skor_developer(p_status_kontrak, p_fitur_selesai, p_jumlah_bug);
    
    -- Untuk Fulltime: Gaji = 5.000.000 + (Skor × 20.000)
    IF LOWER(p_status_kontrak) = 'fulltime' THEN
        v_gaji := 5000000 + (v_skor * 20000);
    
    -- Untuk Freelance: Berdasarkan range skor
    ELSE
        IF v_skor >= 80 THEN
            v_gaji := 500000 * p_fitur_selesai;
        ELSIF v_skor >= 50 THEN
            v_gaji := 400000 * p_fitur_selesai;
        ELSE
            v_gaji := 250000 * p_fitur_selesai;
        END IF;
    END IF;
    
    RETURN v_gaji;
END;
$$ LANGUAGE plpgsql;

-- Function 3: Hitung Total Gaji Proyek
-- Menghitung total gaji semua developer dalam satu proyek
CREATE OR REPLACE FUNCTION hitung_total_gaji_proyek(
    p_id_proyek INT,
    p_exclude_dev_id INT DEFAULT NULL
)
RETURNS NUMERIC AS $$
DECLARE
    v_total NUMERIC;
BEGIN
    SELECT COALESCE(SUM(hitung_gaji_developer(d.status_kontrak, d.fitur_selesai, d.jumlah_bug)), 0)
    INTO v_total
    FROM developer d
    WHERE d.id_proyek = p_id_proyek
        AND (p_exclude_dev_id IS NULL OR d.id_dev != p_exclude_dev_id);
    
    RETURN v_total;
END;
$$ LANGUAGE plpgsql;

-- Function 4: Cek Budget Proyek (Validasi)
-- Mengecek apakah proyek masih dalam budget setelah menambah/update developer
CREATE OR REPLACE FUNCTION cek_budget_proyek(
    p_id_proyek INT,
    p_gaji_baru NUMERIC,
    p_exclude_dev_id INT DEFAULT NULL
)
RETURNS BOOLEAN AS $$
DECLARE
    v_budget NUMERIC;
    v_total_gaji_lain NUMERIC;
    v_total_gaji_baru NUMERIC;
BEGIN
    -- Ambil budget proyek
    SELECT budget INTO v_budget
    FROM proyek
    WHERE id_proyek = p_id_proyek;
    
    -- Hitung total gaji developer lain (exclude yang sedang diupdate)
    v_total_gaji_lain := hitung_total_gaji_proyek(p_id_proyek, p_exclude_dev_id);
    
    -- Hitung total gaji setelah penambahan/update
    v_total_gaji_baru := v_total_gaji_lain + p_gaji_baru;
    
    -- Return TRUE jika budget mencukupi, FALSE jika tidak
    RETURN v_total_gaji_baru <= v_budget;
END;
$$ LANGUAGE plpgsql;

-- =============================================
-- Test Functions (Optional)
-- =============================================

-- Test hitung_skor_developer
-- SELECT hitung_skor_developer('Fulltime', 90, 5);  -- Expected: 425
-- SELECT hitung_skor_developer('Freelance', 5, 5);  -- Expected: 33

-- Test hitung_gaji_developer
-- SELECT hitung_gaji_developer('Fulltime', 90, 5);  -- Expected: 13,500,000
-- SELECT hitung_gaji_developer('Freelance', 5, 5);  -- Expected: 1,250,000

-- Test hitung_total_gaji_proyek
-- SELECT hitung_total_gaji_proyek(1);

-- Test cek_budget_proyek
-- SELECT cek_budget_proyek(1, 5000000);

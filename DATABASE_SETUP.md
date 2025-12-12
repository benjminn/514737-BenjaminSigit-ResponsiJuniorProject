# Setup Database Functions

## Langkah-langkah Setup

### 1. Jalankan SQL Script untuk Create Functions

Buka **pgAdmin** atau **psql** dan jalankan file `database_functions.sql`:

```bash
psql -U postgres -d Responsi_junpro_ben -f database_functions.sql
```

Atau copy-paste isi file `database_functions.sql` ke Query Tool di pgAdmin.

### 2. Fungsi-fungsi yang Dibuat

#### Function 1: `hitung_skor_developer`
Menghitung skor developer berdasarkan status kontrak.

**Parameter:**
- `p_status_kontrak` - Status kontrak ('Fulltime' atau 'Freelance')
- `p_fitur_selesai` - Jumlah fitur yang diselesaikan
- `p_jumlah_bug` - Jumlah bug yang ditemukan

**Return:** INTEGER (Skor)

**Contoh:**
```sql
SELECT hitung_skor_developer('Fulltime', 90, 5);  -- Result: 425
SELECT hitung_skor_developer('Freelance', 5, 5);  -- Result: 33
```

---

#### Function 2: `hitung_gaji_developer`
Menghitung total gaji developer berdasarkan status kontrak dan skor.

**Parameter:**
- `p_status_kontrak` - Status kontrak ('Fulltime' atau 'Freelance')
- `p_fitur_selesai` - Jumlah fitur yang diselesaikan
- `p_jumlah_bug` - Jumlah bug yang ditemukan

**Return:** NUMERIC (Total Gaji)

**Contoh:**
```sql
SELECT hitung_gaji_developer('Fulltime', 90, 5);   -- Result: 13,500,000
SELECT hitung_gaji_developer('Freelance', 5, 5);   -- Result: 1,250,000
```

---

#### Function 3: `hitung_total_gaji_proyek`
Menghitung total gaji semua developer dalam satu proyek.

**Parameter:**
- `p_id_proyek` - ID proyek
- `p_exclude_dev_id` - ID developer yang di-exclude (optional)

**Return:** NUMERIC (Total Gaji Proyek)

**Contoh:**
```sql
SELECT hitung_total_gaji_proyek(1);           -- Total gaji semua developer di proyek 1
SELECT hitung_total_gaji_proyek(1, 3);        -- Total gaji proyek 1, exclude developer ID 3
```

---

#### Function 4: `cek_budget_proyek`
Validasi apakah proyek masih dalam budget setelah penambahan/update developer.

**Parameter:**
- `p_id_proyek` - ID proyek
- `p_gaji_baru` - Gaji developer yang akan ditambahkan/diupdate
- `p_exclude_dev_id` - ID developer yang di-exclude (optional, untuk update)

**Return:** BOOLEAN (TRUE jika budget cukup, FALSE jika tidak)

**Contoh:**
```sql
SELECT cek_budget_proyek(1, 5000000);          -- Cek apakah bisa tambah dev dengan gaji 5jt
SELECT cek_budget_proyek(1, 5000000, 3);       -- Cek untuk update developer ID 3
```

---

## Keuntungan Menggunakan PostgreSQL Functions

✅ **Separation of Concerns** - Logic perhitungan ada di database  
✅ **Reusability** - Function bisa dipakai di query manapun  
✅ **Performance** - Eksekusi lebih cepat di database level  
✅ **Maintainability** - Mudah update logic tanpa ubah kode C#  
✅ **Data Integrity** - Konsistensi perhitungan terjamin  

## Testing

Test semua function dengan query berikut:

```sql
-- Test basic calculations
SELECT 
    hitung_skor_developer('Fulltime', 90, 5) as skor_fulltime,
    hitung_gaji_developer('Fulltime', 90, 5) as gaji_fulltime;

SELECT 
    hitung_skor_developer('Freelance', 5, 5) as skor_freelance,
    hitung_gaji_developer('Freelance', 5, 5) as gaji_freelance;

-- Test dengan data real dari tabel
SELECT 
    d.nama_dev,
    d.status_kontrak,
    d.fitur_selesai,
    d.jumlah_bug,
    hitung_skor_developer(d.status_kontrak, d.fitur_selesai, d.jumlah_bug) as skor,
    hitung_gaji_developer(d.status_kontrak, d.fitur_selesai, d.jumlah_bug) as gaji
FROM developer d;

-- Test total gaji per proyek
SELECT 
    p.nama_proyek,
    p.budget,
    hitung_total_gaji_proyek(p.id_proyek) as total_gaji,
    p.budget - hitung_total_gaji_proyek(p.id_proyek) as sisa_budget
FROM proyek p;
```

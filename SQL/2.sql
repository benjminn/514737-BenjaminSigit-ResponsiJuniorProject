
CREATE TABLE developer (
    id_dev SERIAL PRIMARY KEY,
    id_proyek INT REFERENCES proyek(id_proyek),
    nama_dev VARCHAR(100),
    status_kontrak VARCHAR(50),
    fitur_selesai INT,
    jumlah_bug INT
);
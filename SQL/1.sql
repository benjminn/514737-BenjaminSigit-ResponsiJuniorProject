CREATE TABLE proyek (
    id_proyek SERIAL PRIMARY KEY,
    nama_proyek VARCHAR(100),
    client VARCHAR(100),
    budget NUMERIC(15,2)
);
CREATE TABLE tugas (
    id_tugas bpchar NOT NULL,
    judul_tugas character varying(40) NOT NULL,
    deskripsi_tugas character varying(100) NOT NULL,
    deadline date NOT NULL
)

CREATE TABLE data_admin (
    id_admin bpchar NOT NULL,
    username character varying(40) NOT NULL,
    password_admin character varying(40) NOT NULL
)

CREATE TABLE data_pengguna (
    id_pengguna bpchar NOT NULL,
    email character varying(40) NOT NULL,
    password_pengguna character varying(40) NOT NULL
)


INSERT INTO data_admin VALUES ('01', 'admin', '123');
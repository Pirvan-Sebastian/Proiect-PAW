-- 1. Populare tabel Facultăți
INSERT INTO [dbo].[Facultati] ([Nume], [NumarLocuri]) VALUES
('Cibernetica, Statistica si Informatica Economica', 300),
('Contabilitate si Informatica de Gestiune', 250),
('Management', 200),
('Istorie', 90);

-- 2. Populare tabel Candidați
INSERT INTO [dbo].[Candidati] ([NumeComplet], [CNP]) VALUES
('Popescu Ion', '5010203123456'),
('Ionescu Maria', '6020304234567'),
('Popa Andrei', '5000101345678'),
('Dumitru Elena', '6010505456789');

-- 3. Populare tabel Dosare (Legăm candidații de facultăți pe baza ID-urilor generate automat mai sus)
INSERT INTO [dbo].[Dosare] ([IdCandidat], [IdFacultate], [NotaBac], [NotaExamen]) VALUES
(1, 1, 9.50, 8.80), -- Popescu Ion aplica la Cibernetica
(2, 1, 8.75, 9.20), -- Ionescu Maria aplica la Cibernetica
(3, 2, 7.80, 8.00), -- Popa Andrei aplica la Contabilitate
(4, 3, 9.10, 9.50); -- Dumitru Elena aplica la Management

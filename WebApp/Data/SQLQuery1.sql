Create table Empresa (
	 id int, 
	 Nm_Empresa varchar(50),
	 Cd_Empresa varchar(20),
	 Ds_Cnpj varchar(50),
	 Nr_Total_Onibus varchar(30),
	 Capacidade varchar(20),
	 Data_Cadastro date,
);
Create table Onibus (
	 id int, 
	 Placa varchar(50),
	 NumRota varchar(20),
	 NomRota varchar(50),
	 NumEntradas varchar(30),
	 NumSaida varchar(20),
	 Status varchar(20),
);

Insert into Empresa (id, Nm_Empresa, Cd_Empresa, Ds_Cnpj, Nr_Total_Onibus, Capacidade,Data_Cadastro)
values
(1,'Nova Transporte Ltda', 07, '444.333.785/0001', 22,80, '07/05/22'),
(2,'Metropolitana Transportes e Serviços Ltda', 07, '555.777.159/0001', 15,120, '11/11/19'),
(3,'Consórcio Bus+', 12, '333.555.789/0001', 20,90, '04/05/19'),
(4,'Consórcio Internorte', 08, '123.987.354/0001', 14,120, '22/05/19'),
(5,'Consórcio Anhanguera', 03, '743.398.002/0001', 17,120, '24/12/18'),
(6,'Consórcio Unileste', 01, '342.663.981/0001', 20,150, '07/05/22'),
(7,'Consórcio Intervias', 06, '884.544.121/0001', 25,150, '12/02/22')
;

Insert into Onibus (id, Placa, NumRota, NomRota, NumEntradas, NumSaida,Status)
values
(1,'ABC-1585', 2174, 'Vila Rui Barbosa', 80,80, 'Lotado'),
(2,'EFG-5D84', 4758, 'Metro Carrão', 110,101, ''),
(3,'EKD-7890', 1247, 'Parque Dom Pedro', 150,137, ''),
(4,'POO-2587', 0837, 'Cidade Tiradentes', 60,35, 'Tranquilo'),
(5,'DJM-1A34', 3574, 'Avenida Aricanduva', 90,71, ''),
(6,'IGW-0654', 4761, 'Metrô Vila Mariana', 100,26, ''),
(7,'MFQ-2E67', 5318, 'Praça da Sé', 96,92, '')
;

select * from Empresa;
select * from Onibus;

Drop table Projeto;
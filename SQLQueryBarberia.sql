use [master]

GO

CREATE DATABASE [proyecto_Barberia]
GO 

select *
from sys.databases
where name = 'proyecto_Barberia' 

set quoted_identifier on
GO
/* Set DATEFORMAT so that the date strings are interpreted correctly regardless of
   the default DATEFORMAT on the server.
*/
SET DATEFORMAT dmy
GO

USE proyecto_Barberia 
GO 


CREATE SCHEMA [sch_Administracion]

Go

CREATE SCHEMA [sch_Barberia]

Go

CREATE SCHEMA [sch_RRHH]

Go

Select db_name()
select * from sys.schemas where schema_id <=10

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla [sch_Barberia].[Appointments]
--

CREATE TABLE [sch_Barberia].[Appointments]
(
	[appointment_id]		TINYINT				NOT NULL, --PK
	[date_created]			DATETIME			NOT NULL DEFAULT '00-00-0000 00:00:00', 
	[client_id]				TINYINT				NOT NULL, --FK
	[employee_id]			TINYINT				NOT NULL, --FK
	[start_time]			DATETIME			NOT NULL DEFAULT '00-00-0000 00:00:00',
	[end_time_expected]		DATETIME			NOT NULL DEFAULT '00-00-0000 00:00:00',
	[canceled]				TINYINT				NOT NULL DEFAULT 0,
	[cancellation_reason]	VARCHAR(50)			NULL, 
)

--
-- Volcado de datos para la tabla [sch_Barberia].[Appointments]
--

INSERT INTO [sch_Barberia].[Appointments] (appointment_id, date_created, client_id, employee_id, start_time, end_time_expected, canceled, cancellation_reason) VALUES
(10, '06-02-2024 11:40:00', 11, 3, '07-02-2024 13:30:00', '07-02-2024 14:00:00', 0, NULL),
(11, '08-02-2024 08:40:00', 12, 3, '09-02-2024 08:30:00', '09-02-2024 09:00:00', 0, NULL),
(12, '10-02-2024 20:40:00', 15, 2, '11-02-2024 15:00:00', '11-02-2024 15:30:00', 0, NULL),
(13, '12-02-2024 22:40:00', 16, 1, '17-02-2024 09:00:00', '17-02-2024 09:30:00', 0, NULL),
(14, '14-02-2024 17:40:00', 17, 1, '28-02-2024 13:00:00', '28-02-2024 14:00:00', 0, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla [sch_Administracion].[barber_Admin]
--

CREATE TABLE [sch_Administracion].[barber_Admin]
(
	[admin_id]		TINYINT				NOT NULL, --PK
	[username]		VARCHAR(50)			NOT NULL, --UK
	[email]			VARCHAR(50)			NOT NULL, --UK
	[full_name]		VARCHAR(50)			NOT NULL,
	[password]		VARCHAR(255)		NOT NULL,
)

--
-- Volcado de datos para la tabla [sch_Administracion].[barber_Admin]
--

INSERT INTO [sch_Administracion].[barber_Admin] (admin_id, username, email, full_name, password) VALUES
(1, 'superuser', 'root@superuser.com', 'SuperUser Root Admin', '123456');

--
-- Estructura de tabla para la tabla [sch_RRHH].[Clients]
--


CREATE TABLE [sch_RRHH].[Clients]
(
	[client_id]		TINYINT				NOT NULL, --PK
	[first_name]	VARCHAR(30)			NOT NULL, 
	[last_name]		VARCHAR(30)			NOT NULL,
	[phone_number]	VARCHAR(30)			NOT NULL,
	[client_email]	VARCHAR(50)			NOT NULL, --UK
)

--
-- Volcado de datos para la tabla [sch_RRHH].[Clients]
--

INSERT INTO [sch_RRHH].[Clients] (client_id, first_name, last_name, phone_number, client_email) VALUES
(1, 'Juan', 'Chaves', '113700452', 'jchaves@cliente.com'),
(2, 'Andres', 'Gonzales', '401120562', 'acliente@cliente.com'),
(3, 'Diego', 'Robles', '10584095', 'dcliente@cliente.com'),
(4, 'Adriana', 'Cliente', '306458974', 'adcliente@cliente.com'),
(5, 'Demetrio', 'Clemente', '212546714', 'dclemente@cliente.com'),
(7, 'Artemio', 'Lucian', '52362059', 'alucian@cliente.com'),
(8, 'Emiliano', 'Sanchez', '406985743', 'esanchez@cliente.com'),
(11, 'Carlos', 'Garcia', '115987416', 'cgarcia@cliente.com'),
(12, 'Jhon', 'Juan', '205648972', 'jjuan@cliente.com'),
(15, 'Pedro', 'Usuario', '702589741', 'pusuario@cliente.com'),
(16, 'Martin', 'Estudiante', '605265978', 'mestudiante@cliente.com'),
(17, 'Rafael', 'Pereira', '506258943', 'rpereira@cliente.com');

--
-- Estructura de tabla para la tabla [sch_RRHH].[Employees]
--

CREATE TABLE [sch_RRHH].[Employees]
(
	[employee_id]		TINYINT				NOT NULL, --PK	
	[first_name]		VARCHAR(30)			NOT NULL, 
	[last_name]			VARCHAR(30)			NOT NULL,
	[phone_number]		VARCHAR(30)			NOT NULL,
	[Employee_email]	VARCHAR(50)			NOT NULL,
	
)

--
-- Volcado de datos para la tabla [sch_RRHH].[Employees]
--

INSERT INTO [sch_RRHH].[Employees] (employee_id, first_name, last_name, phone_number, Employee_email) VALUES
(1, 'Alexa', 'Esteticista', '402561456', 'aestetica@barberia.com'),
(2, 'Jose Pablo', 'Barbero', '112450489', 'jpbarberpro@barberia.com'),
(3, 'Pablo', 'Barbero', '500460012', 'pbarbersuperpro@barberia.com');

--
-- Estructura de tabla para la tabla [sch_RRHH].[employees_Schedule]
--

CREATE TABLE [sch_RRHH].[employees_Schedule]
(
	[employees_Schedule_id]		TINYINT				NOT NULL, --PK	
	[employee_id]				TINYINT				NOT NULL, --FK
	[day_id]					TINYINT				NOT NULL, 
	[from_hour]					TIME				NOT NULL,
	[to_hour]					TIME				NOT NULL,	
)

--
-- Volcado de datos para la tabla [sch_RRHH].[employees_Schedule]
--

INSERT INTO [sch_RRHH].[employees_Schedule] (employees_Schedule_id, employee_id, day_id, from_hour, to_hour) VALUES
(41, 1, 1, '09:00:00', '18:00:00'),
(42, 1, 2, '10:00:00', '22:00:00'),
(43, 1, 3, '09:00:00', '18:00:00'),
(44, 1, 4, '08:00:00', '20:00:00'),
(45, 1, 5, '08:00:00', '18:00:00'),
(46, 1, 6, '08:00:00', '18:00:00'),
(47, 1, 7, '09:00:00', '18:00:00'),
(55, 3, 1, '09:00:00', '18:00:00'),
(56, 3, 2, '08:00:00', '18:00:00'),
(57, 3, 3, '10:00:00', '18:00:00'),
(58, 3, 4, '08:00:00', '18:00:00'),
(59, 3, 5, '08:00:00', '18:00:00'),
(60, 3, 6, '08:00:00', '18:00:00'),
(61, 3, 7, '08:00:00', '17:00:00'),
(62, 2, 1, '08:00:00', '17:00:00'),
(63, 2, 2, '09:00:00', '18:00:00'),
(64, 2, 3, '10:00:00', '18:00:00'),
(65, 2, 4, '08:00:00', '18:00:00'),
(66, 2, 5, '08:00:00', '18:00:00'),
(67, 2, 6, '08:00:00', '18:00:00'),
(68, 2, 7, '08:00:00', '18:00:00');

--
-- Estructura de tabla para la tabla [sch_Barberia].[Services]
--
CREATE TABLE [sch_Barberia].[Services]
(
	[service_id]				TINYINT				NOT NULL, --PK	
	[service_name]				VARCHAR(50)			NOT NULL, 
	[service_description]		VARCHAR(255)		NOT NULL, 
	[service_price]				DECIMAL				NOT NULL,
	[service_duration]			TINYINT				NOT NULL,	
	[category_id]				TINYINT				NOT NULL, --FK
)

--
-- Volcado de datos para la tabla [sch_Barberia].[Services]
--

INSERT INTO [sch_Barberia].[Services] (service_id, service_name, service_description, service_price, service_duration, category_id) VALUES
(1, 'Corte de Cabello', 'El barbero es la persona que principalmente corta el cabello del cliente', '8000.00', 30, 6),
(2, 'Peinado', 'El estilista es la persona encargada de peinar al cliente.', '5000.00', 50, 6),
(3, 'Recorte de cabello', 'El barbero es una persona cuya ocupación es principalmente cortar el cabello.', '6000.00', 10, 6),
(4, 'Afeitado Limpio', 'El barbero es una persona cuya tarea es afeitar a los hombres.', '3500.00', 20, 2),
(5, 'Recorte de barba', 'El barbero es una persona que se encarga de afeitar a los hombres.', '5000.00', 40, 2),
(6, 'Afeitado suave', 'El barbero se encarga de afeitar al cliente.', '4000.00', 20, 2),
(7, 'Facial blanca', 'El barbero o estilista es una persona cuya ocupación es principalmente cortar, vestir al estilo del novio y afeitar a los hombres.', '15000.00', 15, 3),
(8, 'Limpieza de Rostro', 'El barbero o estilista se encargan de limpiar el rostro d elos clientes.', '9000.00', 20, 3),
(9, 'Afinación brillante', 'El barbero o estilista se encarga de abrillantar el rostro del cliente.', '12000.00', 20, 3);

--
-- Estructura de tabla para la tabla [sch_Barberia].[services_Booked]
--

CREATE TABLE [sch_Barberia].[services_Booked]
(
	[appointment_id]		TINYINT			NOT NULL,	
	[service_id]			TINYINT			NOT NULL, 

)

--
-- Volcado de datos para la tabla [sch_Barberia].[services_Booked]
--

INSERT INTO [sch_Barberia].[services_Booked] (appointment_id, service_id) VALUES
(10, 4),
(11, 5),
(12, 3),
(13, 1),
(14, 2);

--
-- Estructura de tabla para la tabla [sch_Barberia].[service_Categories]
--

CREATE TABLE [sch_Barberia].[service_Categories]
(
	[category_id]			TINYINT				NOT NULL,	
	[category_name]			VARCHAR(50)			NOT NULL, 

)

--
-- Volcado de datos para la tabla [sch_Barberia].[service_Categories]
--

INSERT INTO [sch_Barberia].[service_Categories] (category_id, category_name) VALUES
(2, 'Afeitado'),
(3, 'Corte Cabello'),
(4, 'Barba'),
(6, 'Peinado');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla [sch_Barberia].[Appointments]
--

--PK
	ALTER TABLE  [sch_Barberia].[Appointments]
	ADD CONSTRAINT [PK_appointment_id]	
	PRIMARY KEY CLUSTERED ([appointment_id] ASC)

--FK -- client>appointments
	ALTER TABLE  [sch_Barberia].[Appointments]
	ADD CONSTRAINT [FK_client_appointment]
	FOREIGN KEY ([client_id]) 
	REFERENCES [sch_RRHH].[Clients] ([client_id]) 

--FK -- Empleados>Ventas
	ALTER TABLE  [sch_Barberia].[Appointments]
	ADD CONSTRAINT [FK_employee_appointment]
	FOREIGN KEY ([employee_id]) 
	REFERENCES [sch_RRHH].[Employees] ([employee_id]) 

--
-- Indices de la tabla [sch_Administracion].[barber_Admin]
--
--PK
	ALTER TABLE  [sch_Administracion].[barber_Admin]
	ADD CONSTRAINT [PK_admin_id]	
	PRIMARY KEY CLUSTERED ([admin_id] ASC)
--UK
	ALTER TABLE [sch_Administracion].[barber_Admin]
	ADD UNIQUE ([username], [email] ASC);


--
-- Indices de la tabla [sch_RRHH].[Clients]
--

--PK
	ALTER TABLE  [sch_RRHH].[Clients]
	ADD CONSTRAINT [PK_client_id]	
	PRIMARY KEY CLUSTERED ([client_id] ASC)
--UK
	ALTER TABLE [sch_RRHH].[Clients]
	ADD UNIQUE (client_email);

--
-- Indices de la tabla [sch_RRHH].[Employees]
--

--PK
	ALTER TABLE  [sch_RRHH].[Employees]
	ADD CONSTRAINT [PK_employee_id]	
	PRIMARY KEY CLUSTERED ([employee_id] ASC)

--
-- Indices de la tabla [sch_RRHH].[employees_Schedule]
--

--PK
	ALTER TABLE  [sch_RRHH].[employees_Schedule]
	ADD CONSTRAINT [PK_employees_Schedule_id]	
	PRIMARY KEY CLUSTERED ([employees_Schedule_id] ASC)

--FK -- Employees>employees_Schedule
	ALTER TABLE  [sch_RRHH].[employees_Schedule]
	ADD CONSTRAINT [FK_employees_employees_Schedule]
	FOREIGN KEY ([employee_id]) 
	REFERENCES [sch_RRHH].[Employees] ([employee_id]) 

--
-- Indices de la tabla [sch_Barberia].[Services]
--

--PK
	ALTER TABLE  [sch_Barberia].[Services]
	ADD CONSTRAINT [PK_service_id]	
	PRIMARY KEY CLUSTERED ([service_id] ASC)

--FK -- service_Categories>Services
	ALTER TABLE  [sch_Barberia].[Services]
	ADD CONSTRAINT [FK_sevices_service_Categories]
	FOREIGN KEY ([category_id]) 
	REFERENCES [sch_Barberia].[service_Categories] ([category_id]) 

--
-- Indices de la tabla [sch_Barberia].[services_Booked]
--

--PK
	ALTER TABLE  [sch_Barberia].[services_Booked]
	ADD CONSTRAINT [PK_appointment_id_service_id]	
	PRIMARY KEY ([appointment_id],[service_id] ASC)

--FK -- Services>services_Booked
	ALTER TABLE  [sch_Barberia].[services_Booked]
	ADD CONSTRAINT [FK_services_Booked_Services]
	FOREIGN KEY ([service_id]) 
	REFERENCES [sch_Barberia].[Services] ([service_id]) 

--
-- Indices de la tabla [sch_Barberia].[service_Categories]
--

--PK
	ALTER TABLE  [sch_Barberia].[service_Categories]
	ADD CONSTRAINT [PK_category_id]	
	PRIMARY KEY CLUSTERED ([category_id] ASC)





	/*
	USE master
	GO 
	
	DROP DATABASE proyecto_Barberia
	GO
	*/
	
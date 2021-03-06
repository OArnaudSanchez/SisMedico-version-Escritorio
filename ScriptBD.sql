USE [SistemaControlMedico]
GO
/****** Object:  Table [dbo].[Altas]    Script Date: 08/04/2020 15:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Altas](
	[idAlta] [int] IDENTITY(0,1) NOT NULL,
	[ingreso] [int] NOT NULL,
	[fechaSalida] [date] NULL,
	[monto] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idAlta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Citas]    Script Date: 08/04/2020 15:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citas](
	[idCita] [int] IDENTITY(0,1) NOT NULL,
	[paciente] [int] NOT NULL,
	[medico] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Habitaciones]    Script Date: 08/04/2020 15:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Habitaciones](
	[idHabitacion] [int] IDENTITY(0,1) NOT NULL,
	[numero] [int] NOT NULL,
	[tipo] [varchar](25) NOT NULL,
	[precioDia] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idHabitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ingresos]    Script Date: 08/04/2020 15:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingresos](
	[idIngreso] [int] IDENTITY(0,1) NOT NULL,
	[paciente] [int] NOT NULL,
	[habitacion] [int] NOT NULL,
	[medico] [int] NOT NULL,
	[fechaIngreso] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idIngreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Medicos]    Script Date: 08/04/2020 15:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Medicos](
	[idMedico] [int] IDENTITY(0,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[exequatur] [varchar](200) NOT NULL,
	[especialidad] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idMedico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 08/04/2020 15:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pacientes](
	[idPaciente] [int] IDENTITY(0,1) NOT NULL,
	[cedula] [varchar](13) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[asegurado] [varchar](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Altas]  WITH CHECK ADD  CONSTRAINT [fk_altas_ingreso] FOREIGN KEY([ingreso])
REFERENCES [dbo].[Ingresos] ([idIngreso])
GO
ALTER TABLE [dbo].[Altas] CHECK CONSTRAINT [fk_altas_ingreso]
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD  CONSTRAINT [fk_citas_medico] FOREIGN KEY([medico])
REFERENCES [dbo].[Medicos] ([idMedico])
GO
ALTER TABLE [dbo].[Citas] CHECK CONSTRAINT [fk_citas_medico]
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD  CONSTRAINT [fk_citas_paciente] FOREIGN KEY([paciente])
REFERENCES [dbo].[Pacientes] ([idPaciente])
GO
ALTER TABLE [dbo].[Citas] CHECK CONSTRAINT [fk_citas_paciente]
GO
ALTER TABLE [dbo].[Ingresos]  WITH CHECK ADD  CONSTRAINT [fk_ingresos_habitacion] FOREIGN KEY([habitacion])
REFERENCES [dbo].[Habitaciones] ([idHabitacion])
GO
ALTER TABLE [dbo].[Ingresos] CHECK CONSTRAINT [fk_ingresos_habitacion]
GO
ALTER TABLE [dbo].[Ingresos]  WITH CHECK ADD  CONSTRAINT [fk_ingresos_medico] FOREIGN KEY([medico])
REFERENCES [dbo].[Medicos] ([idMedico])
GO
ALTER TABLE [dbo].[Ingresos] CHECK CONSTRAINT [fk_ingresos_medico]
GO
ALTER TABLE [dbo].[Ingresos]  WITH CHECK ADD  CONSTRAINT [fk_ingresos_paciente] FOREIGN KEY([paciente])
REFERENCES [dbo].[Pacientes] ([idPaciente])
GO
ALTER TABLE [dbo].[Ingresos] CHECK CONSTRAINT [fk_ingresos_paciente]
GO
/****** Object:  StoredProcedure [dbo].[BuscarIngresosHabitaciones]    Script Date: 08/04/2020 15:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BuscarIngresosHabitaciones]
@tip varchar(10)
as
select i.idIngreso,p.nombre as 'Paciente'
,h.tipo,h.precioDia as 'Precio Habitacion' ,m.nombre as 'Medico', i.fechaIngreso
from Ingresos i
inner Join Habitaciones h on i.habitacion = h.idHabitacion
inner join Pacientes p on i.paciente = p.idPaciente
inner join Medicos m on i.medico = m.idMedico
where tipo like '@tip%'

GO
/****** Object:  StoredProcedure [dbo].[MostrarAltas]    Script Date: 08/04/2020 15:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MostrarAltas]
as
Select a.idAlta as 'ID Alta',i.idIngreso as 'ID Ingreso',p.cedula as 'Cedula Paciente',
p.nombre as 'Paciente',m.nombre as 'Medico',h.tipo as 'Tipo Habitacion',h.precioDia as 'Precio Por Dia',
i.fechaIngreso as 'Fecha de Ingreso', a.fechaSalida as 'Fecha de Salida', a.monto as 'Monto'
from Altas a 
inner join Ingresos i on a.ingreso = i.idIngreso 
inner Join Pacientes p on i.paciente = p.idPaciente
inner join Medicos m on i.medico = m.idMedico
inner join Habitaciones h on i.habitacion = h.idHabitacion
GO
/****** Object:  StoredProcedure [dbo].[MostrarCitas]    Script Date: 08/04/2020 15:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MostrarCitas]
as
select c.idCita, p.nombre as Paciente,m.nombre as Medico,c.fecha
from Citas c 
inner join Pacientes p on c.paciente = p.idPaciente
inner join Medicos m on c.medico = m.idMedico
GO
/****** Object:  StoredProcedure [dbo].[MostrarIngresos]    Script Date: 08/04/2020 15:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MostrarIngresos]
as
select i.idIngreso,p.nombre as 'Paciente'
,h.tipo as 'Habitacion',h.precioDia as 'Precio Habitacion' ,m.nombre as 'Medico', i.fechaIngreso
from Ingresos i
inner Join Habitaciones h on i.habitacion = h.idHabitacion
inner join Pacientes p on i.paciente = p.idPaciente
inner join Medicos m on i.medico = m.idMedico

GO
/****** Object:  StoredProcedure [dbo].[MostrarIngresosFecha]    Script Date: 08/04/2020 15:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MostrarIngresosFecha]
@fecha varchar(25)
as
select i.idIngreso,p.nombre as 'Paciente'
,h.tipo as 'Habitacion',h.precioDia as 'Precio Habitacion' ,m.nombre as 'Medico', i.fechaIngreso
from Ingresos i
inner Join Habitaciones h on i.habitacion = h.idHabitacion
inner join Pacientes p on i.paciente = p.idPaciente
inner join Medicos m on i.medico = m.idMedico
where i.fechaIngreso like '@fecha%'
GO
/****** Object:  StoredProcedure [dbo].[MostrarIngresosHabitaciones]    Script Date: 08/04/2020 15:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MostrarIngresosHabitaciones]
as
select i.idIngreso,p.nombre as 'Paciente'
,h.tipo,h.precioDia as 'Precio Habitacion' ,m.nombre as 'Medico', i.fechaIngreso
from Ingresos i
inner Join Habitaciones h on i.habitacion = h.idHabitacion
inner join Pacientes p on i.paciente = p.idPaciente
inner join Medicos m on i.medico = m.idMedico
GO

USE [GestionDeEmpleados]
GO
SET IDENTITY_INSERT [dbo].[Sucursal] ON 
GO
INSERT [dbo].[Sucursal] ([idSucursal], [Direccion], [Eliminada]) VALUES (2, N'Calle Falsa 123', 0)
GO
INSERT [dbo].[Sucursal] ([idSucursal], [Direccion], [Eliminada]) VALUES (3, N'Avenida Siempre Viva 743', 0)
GO
INSERT [dbo].[Sucursal] ([idSucursal], [Direccion], [Eliminada]) VALUES (4, N'Av. General Paz 2234', 1)
GO
SET IDENTITY_INSERT [dbo].[Sucursal] OFF
GO

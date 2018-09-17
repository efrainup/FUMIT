CREATE VIEW dbo.vsProgramacionServiciosClientes
AS
SELECT        dbo.ProgramacionServiciosClientes.ProgramacionServiciosClienteId, dbo.ProgramacionServiciosClientes.ProgramacionServicioId, 
                         dbo.ProgramacionServiciosClientes.ClienteId, dbo.ProgramacionServiciosClientes.FechaInicio, dbo.ProgramacionServiciosClientes.FechaTermino, 
                         dbo.ProgramacionServiciosClientes.Activo, dbo.ProgramacionServiciosClientes.Borrado, dbo.ProgramacionServiciosClientes.ServicioId, dbo.Servicios.Nombre, 
                         dbo.ProgramacionServicios.Nombre AS NombreHorarioProgramado, dbo.ProgramacionServiciosClientes.Area
FROM            dbo.ProgramacionServiciosClientes INNER JOIN
                         dbo.Servicios ON dbo.ProgramacionServiciosClientes.ServicioId = dbo.Servicios.ServicioId INNER JOIN
                         dbo.ProgramacionServicios ON dbo.ProgramacionServiciosClientes.ProgramacionServicioId = dbo.ProgramacionServicios.ProgramacionServicioId
WHERE        (dbo.ProgramacionServiciosClientes.Borrado = 0)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vsProgramacionServiciosClientes';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[46] 4[30] 2[7] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ProgramacionServiciosClientes"
            Begin Extent = 
               Top = 35
               Left = 73
               Bottom = 262
               Right = 321
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Servicios"
            Begin Extent = 
               Top = 207
               Left = 441
               Bottom = 336
               Right = 611
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "ProgramacionServicios"
            Begin Extent = 
               Top = 7
               Left = 440
               Bottom = 189
               Right = 762
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 4065
         Alias = 2880
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vsProgramacionServiciosClientes';




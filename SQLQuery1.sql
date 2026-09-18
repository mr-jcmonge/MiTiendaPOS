SELECT MigrationId, ProductVersion FROM __EFMigrationsHistory

SELECT f.name as LlaveForanea, OBJECT_NAME(f.parent_object_id)
as Tabla, f.delete_referential_action_desc AS AlEliminar
FROM sys.foreign_keys f ORDER BY Tabla;


select * from Categorias;
select * from Usuarios
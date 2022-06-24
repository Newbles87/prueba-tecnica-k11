-- `mae_departamento` definition

-- Drop table

-- DROP TABLE `mae_departamento`;

CREATE TABLE `mae_departamento` (
	`IdDepartamento` INTEGER NOT NULL,
	`CodigoDepartamento` VARCHAR(255),
	`Descripcion` VARCHAR(255),
	`UsuarioCreacion` INTEGER DEFAULT 0,
	`FechaCreacion` TIMESTAMP,
	`UsuarioModificacion` INTEGER DEFAULT 0,
	`FechaModificacion` TIMESTAMP,
	`Estado` VARCHAR(1),
	CONSTRAINT SYS_PK_10550 PRIMARY KEY (`IdDepartamento`)
);
CREATE UNIQUE INDEX SYS_IDX_SYS_PK_10550_10551 ON `mae_departamento` (`IdDepartamento`);


-- `mae_rector` definition

-- Drop table

-- DROP TABLE `mae_rector`;

CREATE TABLE `mae_rector` (
	`IdRector` INTEGER NOT NULL,
	`Nombres` VARCHAR(255),
	`UsuarioCreacion` INTEGER DEFAULT 0,
	`FechaCreacion` TIMESTAMP,
	`UsuarioModificacion` INTEGER DEFAULT 0,
	`FechaModificacion` TIMESTAMP,
	`Estado` VARCHAR(1),
	`Apellidos` VARCHAR(255),
	`FechaNacimiento` TIMESTAMP,
	`NumeroDocumento` VARCHAR(255),
	`Direccion` VARCHAR(255),
	`Telefono` VARCHAR(255),
	`Celular` VARCHAR(255),
	`CorreoEletronico` VARCHAR(255),
	CONSTRAINT SYS_PK_10578 PRIMARY KEY (`IdRector`)
);
CREATE UNIQUE INDEX SYS_IDX_SYS_PK_10578_10579 ON `mae_rector` (`IdRector`);


-- `mae_seccion_pregunta` definition

-- Drop table

-- DROP TABLE `mae_seccion_pregunta`;

CREATE TABLE `mae_seccion_pregunta` (
	`IdSeccionPregunta` INTEGER NOT NULL,
	`Codigo` VARCHAR(255),
	`Descripcion` VARCHAR(255),
	`Orden` INTEGER DEFAULT 0,
	`UsuarioCreacion` INTEGER DEFAULT 0,
	`FechaCreacion` TIMESTAMP,
	`UsuarioModificacion` INTEGER DEFAULT 0,
	`FechaModificacion` TIMESTAMP,
	`Estado` VARCHAR(1),
	CONSTRAINT SYS_PK_10592 PRIMARY KEY (`IdSeccionPregunta`)
);
CREATE UNIQUE INDEX SYS_IDX_SYS_PK_10592_10593 ON `mae_seccion_pregunta` (`IdSeccionPregunta`);


-- `mae_zona` definition

-- Drop table

-- DROP TABLE `mae_zona`;

CREATE TABLE `mae_zona` (
	`IdZona` INTEGER NOT NULL,
	`CodigoZona` VARCHAR(255),
	`Descripcion` VARCHAR(255),
	`UsuarioCreacion` INTEGER DEFAULT 0,
	`FechaCreacion` TIMESTAMP,
	`UsuarioModificacion` INTEGER DEFAULT 0,
	`FechaModificacion` TIMESTAMP,
	`Estado` VARCHAR(1),
	`Orden` INTEGER DEFAULT 0,
	CONSTRAINT SYS_PK_10606 PRIMARY KEY (`IdZona`)
);
CREATE UNIQUE INDEX SYS_IDX_SYS_PK_10606_10607 ON `mae_zona` (`IdZona`);


-- `tipo_grado` definition

-- Drop table

-- DROP TABLE `tipo_grado`;

CREATE TABLE `tipo_grado` (
	`IdGrado` INTEGER NOT NULL,
	`Descripcion` VARCHAR(255),
	`Orden` INTEGER DEFAULT 0,
	`UsuarioCreacion` INTEGER DEFAULT 0,
	`FechaCreacion` TIMESTAMP,
	`UsuarioModificacion` INTEGER DEFAULT 0,
	`FechaModificacion` TIMESTAMP,
	`Estado` VARCHAR(1),
	CONSTRAINT SYS_PK_10611 PRIMARY KEY (`IdGrado`)
);
CREATE UNIQUE INDEX SYS_IDX_SYS_PK_10611_10612 ON `tipo_grado` (`IdGrado`);


-- `tipo_jornada` definition

-- Drop table

-- DROP TABLE `tipo_jornada`;

CREATE TABLE `tipo_jornada` (
	`IdJornada` INTEGER NOT NULL,
	`Descripcion` VARCHAR(255),
	`Orden` INTEGER DEFAULT 0,
	`UsuarioCreacion` INTEGER DEFAULT 0,
	`FechaCreacion` TIMESTAMP,
	`UsuarioModificacion` INTEGER DEFAULT 0,
	`FechaModificacion` TIMESTAMP,
	`Estado` VARCHAR(1),
	CONSTRAINT SYS_PK_10616 PRIMARY KEY (`IdJornada`)
);
CREATE UNIQUE INDEX SYS_IDX_SYS_PK_10616_10617 ON `tipo_jornada` (`IdJornada`);


-- `tipo_nivel_educativo` definition

-- Drop table

-- DROP TABLE `tipo_nivel_educativo`;

CREATE TABLE `tipo_nivel_educativo` (
	`IdNivelEducativo` INTEGER NOT NULL,
	`Descripcion` VARCHAR(255),
	`Orden` INTEGER DEFAULT 0,
	`UsuarioCreacion` INTEGER DEFAULT 0,
	`FechaCreacion` TIMESTAMP,
	`UsuarioModificacion` INTEGER DEFAULT 0,
	`FechaModificacion` TIMESTAMP,
	`Estado` VARCHAR(1),
	CONSTRAINT SYS_PK_10621 PRIMARY KEY (`IdNivelEducativo`)
);
CREATE UNIQUE INDEX SYS_IDX_SYS_PK_10621_10622 ON `tipo_nivel_educativo` (`IdNivelEducativo`);


-- `tipo_opcion` definition

-- Drop table

-- DROP TABLE `tipo_opcion`;

CREATE TABLE `tipo_opcion` (
	`IdOpcion` INTEGER NOT NULL,
	`Descripcion` VARCHAR(255),
	`Orden` INTEGER DEFAULT 0,
	`UsuarioCreacion` INTEGER DEFAULT 0,
	`FechaCreacion` TIMESTAMP,
	`UsuarioModificacion` INTEGER DEFAULT 0,
	`FechaModificacion` TIMESTAMP,
	`Estado` VARCHAR(1),
	CONSTRAINT SYS_PK_10626 PRIMARY KEY (`IdOpcion`)
);
CREATE UNIQUE INDEX SYS_IDX_SYS_PK_10626_10627 ON `tipo_opcion` (`IdOpcion`);


-- `mae_institucion_educativa` definition

-- Drop table

-- DROP TABLE `mae_institucion_educativa`;

CREATE TABLE `mae_institucion_educativa` (
	`IdInstitucionEducativa` INTEGER NOT NULL,
	`NombreInstitucionEducativa` VARCHAR(255),
	`Telefono` VARCHAR(255),
	`UsuarioCreacion` INTEGER DEFAULT 0,
	`FechaCreacion` TIMESTAMP,
	`UsuarioModificacion` INTEGER DEFAULT 0,
	`FechaModificacion` TIMESTAMP,
	`Estado` VARCHAR(1),
	`IdRector` INTEGER DEFAULT 0,
	`CorreoElectronico` VARCHAR(255),
	CONSTRAINT SYS_PK_10555 PRIMARY KEY (`IdInstitucionEducativa`),
	CONSTRAINT MAE_INSTITUCION_EDUCATIVA_MAE_RECTORMAE_INSTITUCION_EDUCATIVA FOREIGN KEY (`IdRector`) REFERENCES `mae_rector`(`IdRector`)
);
CREATE INDEX SYS_IDX_MAE_INSTITUCION_EDUCATIVA_MAE_RECTORMAE_INSTITUCION_EDUCATIVA_10677 ON `mae_institucion_educativa` (`IdRector`);
CREATE UNIQUE INDEX SYS_IDX_SYS_PK_10555_10556 ON `mae_institucion_educativa` (`IdInstitucionEducativa`);


-- `mae_municipio` definition

-- Drop table

-- DROP TABLE `mae_municipio`;

CREATE TABLE `mae_municipio` (
	`IdMunicipio` INTEGER NOT NULL,
	`IdDepartamento` INTEGER DEFAULT 0,
	`CodigoMunicipio` VARCHAR(255),
	`Descripcion` VARCHAR(255),
	`UsuarioCreacion` INTEGER DEFAULT 0,
	`FechaCreacion` TIMESTAMP,
	`UsuarioModificacion` INTEGER DEFAULT 0,
	`FechaModificacion` TIMESTAMP,
	`Estado` VARCHAR(1),
	CONSTRAINT SYS_PK_10560 PRIMARY KEY (`IdMunicipio`),
	CONSTRAINT MAE_MUNICIPIO_MAE_DEPARTAMENTOMAE_MUNICIPIO FOREIGN KEY (`IdDepartamento`) REFERENCES `mae_departamento`(`IdDepartamento`)
);
CREATE INDEX SYS_IDX_MAE_MUNICIPIO_MAE_DEPARTAMENTOMAE_MUNICIPIO_10684 ON `mae_municipio` (`IdDepartamento`);
CREATE UNIQUE INDEX SYS_IDX_SYS_PK_10560_10561 ON `mae_municipio` (`IdMunicipio`);


-- `mae_pregunta` definition

-- Drop table

-- DROP TABLE `mae_pregunta`;

CREATE TABLE `mae_pregunta` (
	`IdPregunta` INTEGER NOT NULL,
	`Codigo` VARCHAR(255),
	`Descripcion` VARCHAR(255),
	`Orden` INTEGER DEFAULT 0,
	`UsuarioCreacion` INTEGER DEFAULT 0,
	`FechaCreacion` TIMESTAMP,
	`UsuarioModificacion` INTEGER DEFAULT 0,
	`FechaModificacion` TIMESTAMP,
	`Estado` VARCHAR(1),
	`IdOpcion` INTEGER DEFAULT 0,
	`IdSeccionPregunta` INTEGER DEFAULT 0,
	CONSTRAINT SYS_PK_10565 PRIMARY KEY (`IdPregunta`),
	CONSTRAINT MAE_PREGUNTA_MAE_SECCION_PREGUNTAMAE_PREGUNTA FOREIGN KEY (`IdSeccionPregunta`) REFERENCES `mae_seccion_pregunta`(`IdSeccionPregunta`),
	CONSTRAINT MAE_PREGUNTA_TIPO_OPCIONMAE_PREGUNTA FOREIGN KEY (`IdOpcion`) REFERENCES `tipo_opcion`(`IdOpcion`)
);
CREATE UNIQUE INDEX SYS_IDX_MAE_PREGUNTA_IDPREGUNTA1_10574 ON `mae_pregunta` (`IdSeccionPregunta`);
CREATE UNIQUE INDEX SYS_IDX_MAE_PREGUNTA_IDPREGUNTA_10570 ON `mae_pregunta` (`IdOpcion`);
CREATE INDEX SYS_IDX_MAE_PREGUNTA_MAE_SECCION_PREGUNTAMAE_PREGUNTA_10691 ON `mae_pregunta` (`IdSeccionPregunta`);
CREATE INDEX SYS_IDX_MAE_PREGUNTA_TIPO_OPCIONMAE_PREGUNTA_10698 ON `mae_pregunta` (`IdOpcion`);
CREATE UNIQUE INDEX SYS_IDX_SYS_PK_10565_10566 ON `mae_pregunta` (`IdPregunta`);


-- `mae_respuesta` definition

-- Drop table

-- DROP TABLE `mae_respuesta`;

CREATE TABLE `mae_respuesta` (
	`IdRespuesta` INTEGER NOT NULL,
	`IdPregunta` INTEGER DEFAULT 0,
	`Codigo` VARCHAR(255),
	`Descripcion` VARCHAR(255),
	`Orden` INTEGER DEFAULT 0,
	`UsuarioCreacion` INTEGER DEFAULT 0,
	`FechaCreacion` TIMESTAMP,
	`UsuarioModificacion` INTEGER DEFAULT 0,
	`FechaModificacion` TIMESTAMP,
	`Estado` VARCHAR(1),
	CONSTRAINT SYS_PK_10587 PRIMARY KEY (`IdRespuesta`),
	CONSTRAINT MAE_RESPUESTA_MAE_PREGUNTAMAE_RESPUESTA FOREIGN KEY (`IdPregunta`) REFERENCES `mae_pregunta`(`IdPregunta`)
);
CREATE UNIQUE INDEX SYS_IDX_MAE_RESPUESTA_IDPREGUNTA_10583 ON `mae_respuesta` (`IdPregunta`);
CREATE INDEX SYS_IDX_MAE_RESPUESTA_MAE_PREGUNTAMAE_RESPUESTA_10705 ON `mae_respuesta` (`IdPregunta`);
CREATE UNIQUE INDEX SYS_IDX_SYS_PK_10587_10588 ON `mae_respuesta` (`IdRespuesta`);


-- `mae_sede_educativa` definition

-- Drop table

-- DROP TABLE `mae_sede_educativa`;

CREATE TABLE `mae_sede_educativa` (
	`IdSedeEducativa` INTEGER NOT NULL,
	`IdZona` INTEGER DEFAULT 0,
	`NombreSede` VARCHAR(255),
	`Telefono` VARCHAR(255),
	`CorreoElectronico` VARCHAR(255),
	`UsuarioCreacion` INTEGER DEFAULT 0,
	`FechaCreacion` TIMESTAMP,
	`UsuarioModificacion` INTEGER DEFAULT 0,
	`FechaModificacion` TIMESTAMP,
	`Estado` VARCHAR(1),
	`IdInstitucionEducativa` INTEGER DEFAULT 0,
	`IdMunicipio` INTEGER DEFAULT 0,
	`Direccion` VARCHAR(255),
	`Longitud` VARCHAR(255),
	`Latidud` VARCHAR(255),
	CONSTRAINT SYS_PK_10597 PRIMARY KEY (`IdSedeEducativa`),
	CONSTRAINT MAE_SEDE_EDUCATIVA_MAE_INSTITUCION_EDUCATIVAMAE_SEDE_EDUCATIVA FOREIGN KEY (`IdInstitucionEducativa`) REFERENCES `mae_institucion_educativa`(`IdInstitucionEducativa`),
	CONSTRAINT MAE_SEDE_EDUCATIVA_MAE_MUNICIPIOMAE_SEDE_EDUCATIVA FOREIGN KEY (`IdMunicipio`) REFERENCES `mae_municipio`(`IdMunicipio`),
	CONSTRAINT MAE_SEDE_EDUCATIVA_MAE_ZONAMAE_SEDE_EDUCATIVA FOREIGN KEY (`IdZona`) REFERENCES `mae_zona`(`IdZona`)
);
CREATE UNIQUE INDEX SYS_IDX_MAE_SEDE_EDUCATIVA_IDINSTITUCIONEDUCATIVA_10602 ON `mae_sede_educativa` (`IdInstitucionEducativa`);
CREATE INDEX SYS_IDX_MAE_SEDE_EDUCATIVA_MAE_INSTITUCION_EDUCATIVAMAE_SEDE_EDUCATIVA_10712 ON `mae_sede_educativa` (`IdInstitucionEducativa`);
CREATE INDEX SYS_IDX_MAE_SEDE_EDUCATIVA_MAE_MUNICIPIOMAE_SEDE_EDUCATIVA_10726 ON `mae_sede_educativa` (`IdMunicipio`);
CREATE INDEX SYS_IDX_MAE_SEDE_EDUCATIVA_MAE_ZONAMAE_SEDE_EDUCATIVA_10719 ON `mae_sede_educativa` (`IdZona`);
CREATE UNIQUE INDEX SYS_IDX_SYS_PK_10597_10598 ON `mae_sede_educativa` (`IdSedeEducativa`);


-- `trs_cuestionario_infraestructura` definition

-- Drop table

-- DROP TABLE `trs_cuestionario_infraestructura`;

CREATE TABLE `trs_cuestionario_infraestructura` (
	`IdCuestionarioInfraestructura` INTEGER NOT NULL,
	`IdSedeEducativa` INTEGER DEFAULT 0,
	`UsuarioCreacion` INTEGER DEFAULT 0,
	`FechaCreacion` TIMESTAMP,
	`UsuarioModificacion` INTEGER DEFAULT 0,
	`FechaModificacion` TIMESTAMP,
	`Estado` VARCHAR(1),
	`FechaCuestionario` TIMESTAMP,
	`Observaciones` VARCHAR(255),
	CONSTRAINT SYS_PK_10635 PRIMARY KEY (`IdCuestionarioInfraestructura`),
	CONSTRAINT TRS_CUESTIONARIO_INFRAESTRUCTURA_MAE_SEDE_EDUCATIVATRS_CUESTIONARIO_INFRAESTRUCTURA FOREIGN KEY (`IdSedeEducativa`) REFERENCES `mae_sede_educativa`(`IdSedeEducativa`)
);
CREATE UNIQUE INDEX SYS_IDX_SYS_PK_10635_10636 ON `trs_cuestionario_infraestructura` (`IdCuestionarioInfraestructura`);
CREATE UNIQUE INDEX SYS_IDX_TRS_CUESTIONARIO_INFRAESTRUCTURA_IDJORNADASEDE_10631 ON `trs_cuestionario_infraestructura` (`IdSedeEducativa`);
CREATE INDEX SYS_IDX_TRS_CUESTIONARIO_INFRAESTRUCTURA_MAE_SEDE_EDUCATIVATRS_CUESTIONARIO_INFRAESTRUCTURA_10733 ON `trs_cuestionario_infraestructura` (`IdSedeEducativa`);


-- `trs_cuestionario_respuesta` definition

-- Drop table

-- DROP TABLE `trs_cuestionario_respuesta`;

CREATE TABLE `trs_cuestionario_respuesta` (
	`IdCuestionarioRespuesta` INTEGER NOT NULL,
	`IdRespuesta` INTEGER DEFAULT 0,
	`DescripcionRespuestaAbierta` VARCHAR(255),
	`UsuarioCreacion` INTEGER DEFAULT 0,
	`FechaCreacion` TIMESTAMP,
	`UsuarioModificacion` INTEGER DEFAULT 0,
	`FechaModificacion` TIMESTAMP,
	`Estado` VARCHAR(1),
	`IdCuestionarioInfraestructura` INTEGER DEFAULT 0,
	CONSTRAINT SYS_PK_10644 PRIMARY KEY (`IdCuestionarioRespuesta`),
	CONSTRAINT TRS_CUESTIONARIO_RESPUESTA_MAE_RESPUESTATRS_CUESTIONARIO_RESPUESTA FOREIGN KEY (`IdRespuesta`) REFERENCES `mae_respuesta`(`IdRespuesta`),
	CONSTRAINT TRS_CUESTIONARIO_RESPUESTA_TRS_CUESTIONARIO_INFRAESTRUCTTRS_CUESTIONARIO_RESPUESTA FOREIGN KEY (`IdCuestionarioInfraestructura`) REFERENCES `trs_cuestionario_infraestructura`(`IdCuestionarioInfraestructura`)
);
CREATE UNIQUE INDEX SYS_IDX_SYS_PK_10644_10645 ON `trs_cuestionario_respuesta` (`IdCuestionarioRespuesta`);
CREATE UNIQUE INDEX SYS_IDX_TRS_CUESTIONARIO_RESPUESTA_IDCUESTIONARIOINFRAESTRUCTURA_10649 ON `trs_cuestionario_respuesta` (`IdCuestionarioInfraestructura`);
CREATE UNIQUE INDEX SYS_IDX_TRS_CUESTIONARIO_RESPUESTA_IDJORNADASEDE_10640 ON `trs_cuestionario_respuesta` (`IdRespuesta`);
CREATE INDEX SYS_IDX_TRS_CUESTIONARIO_RESPUESTA_MAE_RESPUESTATRS_CUESTIONARIO_RESPUESTA_10740 ON `trs_cuestionario_respuesta` (`IdRespuesta`);
CREATE INDEX SYS_IDX_TRS_CUESTIONARIO_RESPUESTA_TRS_CUESTIONARIO_INFRAESTRUCTTRS_CUESTIONARIO_RESPUESTA_10747 ON `trs_cuestionario_respuesta` (`IdCuestionarioInfraestructura`);


-- `trs_jornada_sede` definition

-- Drop table

-- DROP TABLE `trs_jornada_sede`;

CREATE TABLE `trs_jornada_sede` (
	`IdJornadaSede` INTEGER NOT NULL,
	`UsuarioCreacion` INTEGER DEFAULT 0,
	`FechaCreacion` TIMESTAMP,
	`UsuarioModificacion` INTEGER DEFAULT 0,
	`FechaModificacion` TIMESTAMP,
	`Estado` VARCHAR(1),
	`IdSedeEducativa` INTEGER DEFAULT 0,
	`IdJornada` INTEGER DEFAULT 0,
	`IdGrado` INTEGER DEFAULT 0,
	`IdNivelEducativo` INTEGER DEFAULT 0,
	CONSTRAINT SYS_PK_10653 PRIMARY KEY (`IdJornadaSede`),
	CONSTRAINT TRS_JORNADA_SEDE_MAE_SEDE_EDUCATIVATRS_JORNADA_SEDE FOREIGN KEY (`IdSedeEducativa`) REFERENCES `mae_sede_educativa`(`IdSedeEducativa`),
	CONSTRAINT TRS_JORNADA_SEDE_TIPO_GRADOTRS_JORNADA_SEDE FOREIGN KEY (`IdGrado`) REFERENCES `tipo_grado`(`IdGrado`),
	CONSTRAINT TRS_JORNADA_SEDE_TIPO_JORNADATRS_JORNADA_SEDE FOREIGN KEY (`IdJornada`) REFERENCES `tipo_jornada`(`IdJornada`),
	CONSTRAINT TRS_JORNADA_SEDE_TIPO_NIVEL_EDUCATIVOTRS_JORNADA_SEDE FOREIGN KEY (`IdNivelEducativo`) REFERENCES `tipo_nivel_educativo`(`IdNivelEducativo`)
);
CREATE UNIQUE INDEX SYS_IDX_SYS_PK_10653_10654 ON `trs_jornada_sede` (`IdJornadaSede`);
CREATE UNIQUE INDEX SYS_IDX_TRS_JORNADA_SEDE_IDJORNADASEDE1_10662 ON `trs_jornada_sede` (`IdJornada`);
CREATE UNIQUE INDEX SYS_IDX_TRS_JORNADA_SEDE_IDJORNADASEDE2_10666 ON `trs_jornada_sede` (`IdGrado`);
CREATE UNIQUE INDEX SYS_IDX_TRS_JORNADA_SEDE_IDJORNADASEDE3_10670 ON `trs_jornada_sede` (`IdNivelEducativo`);
CREATE UNIQUE INDEX SYS_IDX_TRS_JORNADA_SEDE_IDJORNADASEDE_10658 ON `trs_jornada_sede` (`IdSedeEducativa`);
CREATE INDEX SYS_IDX_TRS_JORNADA_SEDE_MAE_SEDE_EDUCATIVATRS_JORNADA_SEDE_10754 ON `trs_jornada_sede` (`IdSedeEducativa`);
CREATE INDEX SYS_IDX_TRS_JORNADA_SEDE_TIPO_GRADOTRS_JORNADA_SEDE_10768 ON `trs_jornada_sede` (`IdGrado`);
CREATE INDEX SYS_IDX_TRS_JORNADA_SEDE_TIPO_JORNADATRS_JORNADA_SEDE_10761 ON `trs_jornada_sede` (`IdJornada`);
CREATE INDEX SYS_IDX_TRS_JORNADA_SEDE_TIPO_NIVEL_EDUCATIVOTRS_JORNADA_SEDE_10775 ON `trs_jornada_sede` (`IdNivelEducativo`);
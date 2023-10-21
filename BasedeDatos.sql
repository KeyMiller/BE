CREATE DATABASE BodegaYanin;
USE BodegaYanin;
CREATE TABLE TipoDocumentos
(
    Tipo    VARCHAR(10) NOT NULL,
    Descripcion VARCHAR(40) NOT NULL,
    CodigoDocumento INT AUTO_INCREMENT,
    PRIMARY KEY(CodigoDocumento)
)
ALTER TABLE TipoDocumentos AUTO_INCREMENT=100;
--------------------------------------------------------------------------------------------
CREATE TABLE Direcciones
(
    CodigoDireccion INT auto_increment,
    Ubigeo          VARCHAR(6),
    Departamento    VARCHAR(20),
    Provincia       VARCHAR(20),
    Distrito        VARCHAR(20),
    urbanizacion    VARCHAR(150),
    Calle           VARCHAR(40) NOT NULL,
    Referencia      VARCHAR(150) NOT NULL,
      PRIMARY KEY(CodigoDireccion)
)
ALTER TABLE Direcciones AUTO_INCREMENT=100;
--------------------------------------------------------------------------------------------
CREATE TABLE Categorias
(
    CodigoCategoria INT  auto_increment,
    Tipo            VARCHAR(40) unique  NOT NULL,
    Descripcion     VARCHAR(150)        NOT NULL,
    Estado          BIT                 NOT NULL    default(1),
     PRIMARY KEY( CodigoCategoria)
)
ALTER TABLE Categorias AUTO_INCREMENT=100;
--------------------------------------------------------------------------------------------
CREATE TABLE SubCategorias
(
    CodigoSubCategoria INT  auto_increment,
    CodigoCategoria INT NOT null,
    Tipo            VARCHAR(40) unique  NOT NULL,
    Descripcion     VARCHAR(150)        NOT NULL,
    Estado          BIT                 NOT NULL    default(1),
    foreign key(CodigoCategoria) references Categorias(CodigoCategoria),
    PRIMARY KEY( CodigoSubCategoria)
)
ALTER TABLE SubCategorias AUTO_INCREMENT=100;
--------------------------------------------------------------------------------------------
CREATE TABLE Comprobantes
(
    CodigoRecibo    INT auto_increment,
    Tipo            VARCHAR(40) NOT NULL,
    PRIMARY KEY( CodigoRecibo)
);
ALTER TABLE Comprobantes AUTO_INCREMENT=100;
--------------------------------------------------------------------------------------------
CREATE TABLE UnidadMedidas
(
    CodigoUnMedida  INT auto_increment,
    Nombre      VARCHAR(40) NOT NULL unique,
    Estado      BIT     NOT NULL default(1),
    PRIMARY KEY( CodigoUnMedida)
)
ALTER TABLE UnidadMedidas AUTO_INCREMENT=100;
--------------------------------------------------------------------------------------------
CREATE TABLE Personas
(   CodigoPersona   INT auto_increment,
    CodigoDocumento INT NOT NULL,
    CodigoDireccion INT NOT NULL,
    Nombres         VARCHAR(50) NOT NULL,
    ApPaterno       VARCHAR(60) NOT NULL,
    ApMaterno       VARCHAR(60) NOT NULL,
    Sexo            CHAR(1)     NOT NULL,
    FechaNacimiento DATETIME    NOT NULL,
    Usuario         VARCHAR(70) unique NOT NULL,
    Correo          VARCHAR(60) unique NOT NULL,
    Contrasenia     VARCHAR(10) NOT NULL,
    Celular         VARCHAR(12),
    Cargo           BIT         NOT NULL,
    foreign key(CodigoDocumento)  references TipoDocumentos(CodigoDocumento),
    foreign key(CodigoDireccion)  references Direcciones(CodigoDireccion),
    PRIMARY KEY( CodigoPersona)
)
ALTER TABLE Personas AUTO_INCREMENT=100;
--------------------------------------------------------------------------------------------
CREATE TABLE Clientes
(
    CodigoCliente   INT  auto_increment,
    CodigoPersona INT NOT NULL,
    DetallePerfil   VARCHAR(70) NOT NULL,
    FOREIGN KEY(CodigoPersona) REFERENCES Personas(CodigoPersona),
    PRIMARY KEY( CodigoCliente )
)
ALTER TABLE Clientes AUTO_INCREMENT=100;
--------------------------------------------------------------------------------------------
CREATE TABLE CargoColaborativos
(
    CodigoCargo INT auto_increment,
    Nombre      VARCHAR(200) NOT NULL,
    Funcion     VARCHAR(200) NOT NULL,
    PRIMARY KEY(  CodigoCargo )
)
ALTER TABLE CargoColaborativos AUTO_INCREMENT=100;
-------------------------------------------------------------------------------------------
CREATE TABLE Colaborativos
(
    CodigoColaborativos INT auto_increment,
    CodigoPersona INT NOT NULL,
    CodigoCargoColaborativos INT NOT NULL,
    Usuario     VARCHAR(70) NOT NULL,
    Foto        VARCHAR(70) NOT NULL,
    Experiencia VARCHAR(200) NOT NULL,
    FOREIGN KEY(CodigoPersona) REFERENCES Personas(CodigoPersona),
    FOREIGN KEY(CodigoCargoColaborativos) REFERENCES CargoColaborativos(CodigoCargo),
    PRIMARY KEY(CodigoColaborativos)
)
ALTER TABLE Colaborativos AUTO_INCREMENT=100;
--------------------------------------------------------------------------------------------
CREATE TABLE Tipopagos
(
    CodigoTipopagos  INT auto_increment,
    Nombre          varchar(20)     NOT NULL,
    PRIMARY KEY(CodigoTipopagos)
)
ALTER TABLE Tipopagos AUTO_INCREMENT=100;
--------------------------------------------------------------------------------------------
CREATE TABLE pagos
(
    Codigopagos     INT auto_increment,
    Monto           decimal(8,2)    NOT NULL,
    CodigoTipopagos INT NOT NULL,
    foreign key(CodigoTipopagos) REFERENCES Tipopagos(CodigoTipopagos),
    PRIMARY KEY(Codigopagos)
)
ALTER TABLE pagos AUTO_INCREMENT=100;
---------------------------------------------------------------------------------------
CREATE TABLE Envios
(
    CodigoEnvio         INT auto_increment,
    CodigoRecibo        INT NOT NULL,
    CodigoDireccion     INT NOT NULL,
    CodigoColaborativos INT NOT NULL,
    foreign key(CodigoRecibo) REFERENCES Comprobantes(CodigoRecibo),
    foreign key(CodigoDireccion) REFERENCES Direcciones(CodigoDireccion),
     foreign key(CodigoColaborativos) REFERENCES Colaborativos(CodigoColaborativos),
    PRIMARY KEY( CodigoEnvio)
);
ALTER TABLE Envios AUTO_INCREMENT=100;
CREATE TABLE Clientes
(
    CodigoCliente   INT  auto_increment,
    CodigoPersona INT NOT NULL,
    DetallePerfil   VARCHAR(70) NOT NULL,
    FOREIGN KEY(CodigoPersona) REFERENCES Personas(CodigoPersona),
    PRIMARY KEY( CodigoCliente )
)
ALTER TABLE Clientes AUTO_INCREMENT=100;

-----------------------------------------------------------------------------------------------------------------
CREATE TABLE Pedidos
(
    CodigoPedido INT auto_increment,
    CodigoCliente INT NOT NULL,
    CodigoEnvio INT NOT NULL,
    Codigopagos INT NOT NULL,
    RegistroPe  DATETIME    NOT NULL,
    EntregaPe   DATETIME    NOT NULL,
    FOREIGN KEY(CodigoCliente) REFERENCES Clientes(CodigoCliente),
    FOREIGN KEY(CodigoEnvio) REFERENCES Envios(CodigoEnvio),
    FOREIGN KEY(Codigopagos) REFERENCES pagos(Codigopagos),
    PRIMARY KEY( CodigoPedido)
)
ALTER TABLE Pedidos AUTO_INCREMENT=100;
--------------------------------------------------------------------------------------------
CREATE TABLE Productos
(
    CodigoProducto  INT auto_increment,
    CodigoUnMedida  INT NOT NULL,
    CodigoCategoria INT NOT NULL,
    CodigoSubCategoria INT NOT NULL,
    CodigoPedido    INT NOT NULL,
    Nombre          VARCHAR(70)     NOT NULL,
    Stock           CHAR(4)         NOT NULL,
    Precio          DECIMAL(8,2)    NOT NULL,
    Imagen          VARCHAR(50)     NOT NULL,
    Descripcion     VARCHAR(200)    NOT NULL,
    FOREIGN KEY(CodigoUnMedida)   REFERENCES UnidadMedidas(CodigoUnMedida),
    FOREIGN KEY(CodigoCategoria) REFERENCES Categorias(CodigoCategoria),
    FOREIGN KEY( CodigoSubCategoria) REFERENCES SubCategorias(CodigoSubCategoria),
     FOREIGN KEY(CodigoPedido) REFERENCES Pedidos(CodigoPedido),
      PRIMARY KEY( CodigoProducto ) 
)
ALTER TABLE Productos AUTO_INCREMENT=100;
---------------------------------------------------------------------------------------------------
CREATE TABLE DetallePedidos
(
    CodigoDetallePedido INT auto_increment,
    PrecioTotal         decimal(8,2) NOT NULL,
    PrecioUnitario      decimal(8,2) NOT NULL,
    CodigoPedido        INT NOT NULL,
    FOREIGN KEY(CodigoPedido) REFERENCES Pedidos(CodigoPedido),
    PRIMARY KEY( CodigoDetallePedido ) 
)   
ALTER TABLE DetallePedidos AUTO_INCREMENT=100;
--------------------------------------------------------------------------------------------------------
CREATE TABLE Cajas
(
    CodigoCaja          INT auto_increment,
    Fecha               datetime,
    UsuarioApertura     varchar(50),
    UsuarioCierre       varchar(50),
    estado              bit     not null,
    MontoApertura       decimal(10,2),
    MontoCierre         decimal(10,2),
    MontoAdicional      decimal(10,2),
    CodigoColaborativos  int not null,
    Codigopagos  int not null,
    FOREIGN KEY(CodigoColaborativos) REFERENCES Colaborativos(CodigoColaborativos),
    FOREIGN KEY(Codigopagos) REFERENCES pagos(Codigopagos),
    PRIMARY KEY( CodigoCaja) 
)   
ALTER TABLE Cajas AUTO_INCREMENT=100;
------------------------------------------------------------------------------------------
CREATE TABLE MovimientoCajas
(
    CodigoMovimientoCaja        INT auto_increment,
    tipo                VARCHAR(30),
    Monto               decimal(10,2),
    CodigoDetallePedido int not null,
    CodigoCaja int not null,
    FOREIGN KEY(CodigoDetallePedido) REFERENCES DetallePedidos(CodigoDetallePedido),
    FOREIGN KEY(CodigoCaja) REFERENCES Cajas(CodigoCaja),
    PRIMARY KEY( CodigoMovimientoCaja) 
)
ALTER TABLE MovimientoCajas AUTO_INCREMENT=100;
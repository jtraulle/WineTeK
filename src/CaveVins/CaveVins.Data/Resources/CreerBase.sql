/*==============================================================*/
/* Nom de SGBD :  Microsoft SQL Server 2008                     */
/* Date de création :  05/11/2012 14:51:13                      */
/*==============================================================*/
Use master
GO
create Database Cave_Vins
GO
Use Cave_Vins
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('T_APPELLATION_APT') and o.name = 'FK_T_APPELL_POSSEDE_T_REGION')
alter table T_APPELLATION_APT
   drop constraint FK_T_APPELL_POSSEDE_T_REGION
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('T_BOUTEILLE_BTL') and o.name = 'FK_T_BOUTEI_A_POUR_CO_T_FLACON')
alter table T_BOUTEILLE_BTL
   drop constraint FK_T_BOUTEI_A_POUR_CO_T_FLACON
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('T_BOUTEILLE_BTL') and o.name = 'FK_T_BOUTEI_EST_DE_T_COULEU')
alter table T_BOUTEILLE_BTL
   drop constraint FK_T_BOUTEI_EST_DE_T_COULEU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('T_BOUTEILLE_BTL') and o.name = 'FK_T_BOUTEI_PRODUIT_T_CHATEA')
alter table T_BOUTEILLE_BTL
   drop constraint FK_T_BOUTEI_PRODUIT_T_CHATEA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('T_CHATEAU_CHT') and o.name = 'FK_T_CHATEA_A_POUR_T_APPELL')
alter table T_CHATEAU_CHT
   drop constraint FK_T_CHATEA_A_POUR_T_APPELL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('T_REGION_REG') and o.name = 'FK_T_REGION_APPARTIEN_T_PAYS_P')
alter table T_REGION_REG
   drop constraint FK_T_REGION_APPARTIEN_T_PAYS_P
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('T_APPELLATION_APT')
            and   name  = 'POSSEDE_FK'
            and   indid > 0
            and   indid < 255)
   drop index T_APPELLATION_APT.POSSEDE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('T_APPELLATION_APT')
            and   type = 'U')
   drop table T_APPELLATION_APT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('T_BOUTEILLE_BTL')
            and   name  = 'PRODUIT_FK'
            and   indid > 0
            and   indid < 255)
   drop index T_BOUTEILLE_BTL.PRODUIT_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('T_BOUTEILLE_BTL')
            and   name  = 'A_POUR_CONTENANCE_FK'
            and   indid > 0
            and   indid < 255)
   drop index T_BOUTEILLE_BTL.A_POUR_CONTENANCE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('T_BOUTEILLE_BTL')
            and   name  = 'EST_DE_FK'
            and   indid > 0
            and   indid < 255)
   drop index T_BOUTEILLE_BTL.EST_DE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('T_BOUTEILLE_BTL')
            and   type = 'U')
   drop table T_BOUTEILLE_BTL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('T_CHATEAU_CHT')
            and   name  = 'A_POUR_FK'
            and   indid > 0
            and   indid < 255)
   drop index T_CHATEAU_CHT.A_POUR_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('T_CHATEAU_CHT')
            and   type = 'U')
   drop table T_CHATEAU_CHT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('T_COULEUR_CLR')
            and   type = 'U')
   drop table T_COULEUR_CLR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('T_FLACONNAGE_FCG')
            and   type = 'U')
   drop table T_FLACONNAGE_FCG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('T_PAYS_PAY')
            and   type = 'U')
   drop table T_PAYS_PAY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('T_REGION_REG')
            and   name  = 'APPARTIENT_A_FK'
            and   indid > 0
            and   indid < 255)
   drop index T_REGION_REG.APPARTIENT_A_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('T_REGION_REG')
            and   type = 'U')
   drop table T_REGION_REG
go

/*==============================================================*/
/* Table : T_APPELLATION_APT                                    */
/*==============================================================*/
create table T_APPELLATION_APT (
   APT_I_ID             int                  not null IDENTITY(1,1),
   REG_C_CODE           char(3)              not null,
   APT_S_NOM            varchar(50)          not null,
   constraint PK_T_APPELLATION_APT primary key nonclustered (APT_I_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sys.sp_addextendedproperty 'MS_Description', 
   'Appelation du vin : Corbière, Pommard, Pomerol, St Emilion, Margaux, ...',
   'user', @CurrentUser, 'table', 'T_APPELLATION_APT'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Identifiant de l''Appelation',
   'user', @CurrentUser, 'table', 'T_APPELLATION_APT', 'column', 'APT_I_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Code la région : BOR pour Bordeaux par exemple',
   'user', @CurrentUser, 'table', 'T_APPELLATION_APT', 'column', 'REG_C_CODE'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Nom de l''appelation',
   'user', @CurrentUser, 'table', 'T_APPELLATION_APT', 'column', 'APT_S_NOM'
go

/*==============================================================*/
/* Index : POSSEDE_FK                                           */
/*==============================================================*/
create index POSSEDE_FK on T_APPELLATION_APT (
REG_C_CODE ASC
)
go

/*==============================================================*/
/* Table : T_BOUTEILLE_BTL                                      */
/*==============================================================*/
create table T_BOUTEILLE_BTL (
   BTL_I_ID             bigint               not null IDENTITY(1,1),
   FCG_I_ID             int                  not null,
   CHT_I_ID             bigint               not null,
   CLR_I_ID             int                  not null,
   BTL_I_MILLESIME      int                  not null,
   BTL_R_PRIXBAS        float                null,
   BTL_R_PRIXHAUT       float                null,
   constraint PK_T_BOUTEILLE_BTL primary key nonclustered (BTL_I_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sys.sp_addextendedproperty 'MS_Description', 
   'Définie une bouteille de vin',
   'user', @CurrentUser, 'table', 'T_BOUTEILLE_BTL'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Identifiant de la bouteille',
   'user', @CurrentUser, 'table', 'T_BOUTEILLE_BTL', 'column', 'BTL_I_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Identifiant de flacon',
   'user', @CurrentUser, 'table', 'T_BOUTEILLE_BTL', 'column', 'FCG_I_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Identifiant du chateau',
   'user', @CurrentUser, 'table', 'T_BOUTEILLE_BTL', 'column', 'CHT_I_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Identifiant de la couleur',
   'user', @CurrentUser, 'table', 'T_BOUTEILLE_BTL', 'column', 'CLR_I_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Millesime : Année en entier',
   'user', @CurrentUser, 'table', 'T_BOUTEILLE_BTL', 'column', 'BTL_I_MILLESIME'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Prix bas constaté',
   'user', @CurrentUser, 'table', 'T_BOUTEILLE_BTL', 'column', 'BTL_R_PRIXBAS'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Prix Haut constaté',
   'user', @CurrentUser, 'table', 'T_BOUTEILLE_BTL', 'column', 'BTL_R_PRIXHAUT'
go

/*==============================================================*/
/* Index : EST_DE_FK                                            */
/*==============================================================*/
create index EST_DE_FK on T_BOUTEILLE_BTL (
CLR_I_ID ASC
)
go

/*==============================================================*/
/* Index : A_POUR_CONTENANCE_FK                                 */
/*==============================================================*/
create index A_POUR_CONTENANCE_FK on T_BOUTEILLE_BTL (
FCG_I_ID ASC
)
go

/*==============================================================*/
/* Index : PRODUIT_FK                                           */
/*==============================================================*/
create index PRODUIT_FK on T_BOUTEILLE_BTL (
CHT_I_ID ASC
)
go

/*==============================================================*/
/* Table : T_CHATEAU_CHT                                        */
/*==============================================================*/
create table T_CHATEAU_CHT (
   CHT_I_ID             bigint               not null IDENTITY(1,1),
   APT_I_ID             int                  not null,
   CHT_S_CHATEAU        varchar(100)         not null,
   CHT_T_DESCRIPTION    text                 null,
   constraint PK_T_CHATEAU_CHT primary key nonclustered (CHT_I_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sys.sp_addextendedproperty 'MS_Description', 
   'Définie un chateau producteur de vins. Un chateau peu produire plusieurs vins différents.',
   'user', @CurrentUser, 'table', 'T_CHATEAU_CHT'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Identifiant du chateau',
   'user', @CurrentUser, 'table', 'T_CHATEAU_CHT', 'column', 'CHT_I_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Identifiant de l''Appelation',
   'user', @CurrentUser, 'table', 'T_CHATEAU_CHT', 'column', 'APT_I_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Nom du Chateau',
   'user', @CurrentUser, 'table', 'T_CHATEAU_CHT', 'column', 'CHT_S_CHATEAU'
go

/*==============================================================*/
/* Index : A_POUR_FK                                            */
/*==============================================================*/
create index A_POUR_FK on T_CHATEAU_CHT (
APT_I_ID ASC
)
go

/*==============================================================*/
/* Table : T_COULEUR_CLR                                        */
/*==============================================================*/
create table T_COULEUR_CLR (
   CLR_I_ID             int                  not null IDENTITY(1,1),
   CLR_S_NOM            varchar(50)          not null,
   constraint PK_T_COULEUR_CLR primary key nonclustered (CLR_I_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sys.sp_addextendedproperty 'MS_Description', 
   'Couleur du vin',
   'user', @CurrentUser, 'table', 'T_COULEUR_CLR'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Identifiant de la couleur',
   'user', @CurrentUser, 'table', 'T_COULEUR_CLR', 'column', 'CLR_I_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Nom de la couleur',
   'user', @CurrentUser, 'table', 'T_COULEUR_CLR', 'column', 'CLR_S_NOM'
go

/*==============================================================*/
/* Table : T_FLACONNAGE_FCG                                     */
/*==============================================================*/
create table T_FLACONNAGE_FCG (
   FCG_I_ID             int                  not null IDENTITY(1,1),
   FCG_S_NOM            varchar(50)          not null,
   FCG_R_CONTENANCE     int                  not null,
   constraint PK_T_FLACONNAGE_FCG primary key nonclustered (FCG_I_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sys.sp_addextendedproperty 'MS_Description', 
   'Type de Flacon : Contenance en litre et nom',
   'user', @CurrentUser, 'table', 'T_FLACONNAGE_FCG'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Identifiant de flacon',
   'user', @CurrentUser, 'table', 'T_FLACONNAGE_FCG', 'column', 'FCG_I_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Nom du flacon : Bouteille, Magnum, ...',
   'user', @CurrentUser, 'table', 'T_FLACONNAGE_FCG', 'column', 'FCG_S_NOM'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contenance exprimé en litre.',
   'user', @CurrentUser, 'table', 'T_FLACONNAGE_FCG', 'column', 'FCG_R_CONTENANCE'
go

/*==============================================================*/
/* Table : T_PAYS_PAY                                           */
/*==============================================================*/
create table T_PAYS_PAY (
   PAY_C_CODE           char(3)              not null,
   PAY_S_NOM            varchar(50)          not null,
   constraint PK_T_PAYS_PAY primary key nonclustered (PAY_C_CODE)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sys.sp_addextendedproperty 'MS_Description', 
   'Pays producteur',
   'user', @CurrentUser, 'table', 'T_PAYS_PAY'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Code du pays. Exemple FRA pour France.',
   'user', @CurrentUser, 'table', 'T_PAYS_PAY', 'column', 'PAY_C_CODE'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Nom du pays',
   'user', @CurrentUser, 'table', 'T_PAYS_PAY', 'column', 'PAY_S_NOM'
go

/*==============================================================*/
/* Table : T_REGION_REG                                         */
/*==============================================================*/
create table T_REGION_REG (
   REG_C_CODE           char(3)              not null,
   PAY_C_CODE           char(3)              not null,
   REG_S_NOM            varchar(50)          not null,
   constraint PK_T_REGION_REG primary key nonclustered (REG_C_CODE)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sys.sp_addextendedproperty 'MS_Description', 
   'Région du vin : Bordeaux, Champagne, Alsace, ...',
   'user', @CurrentUser, 'table', 'T_REGION_REG'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Code la région : BOR pour Bordeaux par exemple',
   'user', @CurrentUser, 'table', 'T_REGION_REG', 'column', 'REG_C_CODE'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Code du pays. Exemple FRA pour France.',
   'user', @CurrentUser, 'table', 'T_REGION_REG', 'column', 'PAY_C_CODE'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Nom de la région',
   'user', @CurrentUser, 'table', 'T_REGION_REG', 'column', 'REG_S_NOM'
go

/*==============================================================*/
/* Index : APPARTIENT_A_FK                                      */
/*==============================================================*/
create index APPARTIENT_A_FK on T_REGION_REG (
PAY_C_CODE ASC
)
go

alter table T_APPELLATION_APT
   add constraint FK_T_APPELL_POSSEDE_T_REGION foreign key (REG_C_CODE)
      references T_REGION_REG (REG_C_CODE)
go

alter table T_BOUTEILLE_BTL
   add constraint FK_T_BOUTEI_A_POUR_CO_T_FLACON foreign key (FCG_I_ID)
      references T_FLACONNAGE_FCG (FCG_I_ID)
go

alter table T_BOUTEILLE_BTL
   add constraint FK_T_BOUTEI_EST_DE_T_COULEU foreign key (CLR_I_ID)
      references T_COULEUR_CLR (CLR_I_ID)
go

alter table T_BOUTEILLE_BTL
   add constraint FK_T_BOUTEI_PRODUIT_T_CHATEA foreign key (CHT_I_ID)
      references T_CHATEAU_CHT (CHT_I_ID)
go

alter table T_CHATEAU_CHT
   add constraint FK_T_CHATEA_A_POUR_T_APPELL foreign key (APT_I_ID)
      references T_APPELLATION_APT (APT_I_ID)
go

alter table T_REGION_REG
   add constraint FK_T_REGION_APPARTIEN_T_PAYS_P foreign key (PAY_C_CODE)
      references T_PAYS_PAY (PAY_C_CODE)
go


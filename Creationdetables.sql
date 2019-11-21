use BD5B6TP2Marrero_Kouma

print '=============================Suppression des tables ==========================='

drop table Dependants

drop table Depenses

drop table Services

drop table Employes



drop table TypesEmploye

drop table PartiesJouees

drop table Terrains

drop table Reabonnements

drop table Abonnements

drop table PrixDepensesAbonnements

drop table TypesAbonnement
drop table Provinces
/*










*/

print '=============================Création des tables ==========================='
print 'Création table Provinces'
create table Provinces(
Id char(2) COLLATE Latin1_General_CS_AS constraint CK_Idprov1 check (Id IN ('AB','BC','PE','MB','NB','NS','NU','ON','QC','SK','NL','YT','NT'))  primary key(Id) not null,
Nom varchar(50) not null,
Remarque varchar(50)
) 
print 'Création table TypesAbonnement'
create table TypesAbonnement(
No int primary key(No) not null,
Description varchar(50),
Remarque varchar(50)
)
print 'Création table PrixDepensesAbonnements'
create table PrixDepensesAbonnements(
NoTypeAbonnement int foreign key(NoTypeAbonnement) references TypesAbonnement(No) not null,
Annee int not null,
Prix int not null,
DepensesObligatoires varchar(50),
Remarque varchar(50),
constraint pk_PrixDepensesAbonnements primary key(NoTypeAbonnement,Annee)
)

print 'Création table Abonnements'
create table Abonnements(
Id int primary key(Id) not null,
DateAbonnement date not null,
Nom varchar(50) not null,
Prenom varchar(50) not null,
Sexe varchar(1) constraint ck_sexe2 check (UPPER(Sexe) in ('H','F')) not null,
DateNaissance date not null,
NoCivique int not null,
Rue varchar(50) not null,
Ville varchar(50) not null,
IdProvince char(2) COLLATE Latin1_General_CS_AS constraint CK_Idprov2 check (IdProvince IN ('AB','BC','PE','MB','NB','NS','NU','ON','QC','SK','NL','YT','NT')) foreign key(IdProvince) references Provinces(Id) not null,
CodePostal varchar(6) not null,
Telephone varchar(10) not null,
Cellulaire varchar(10) not null,
Courriel varchar(50) not null,
NoTypeAbonnement int not null foreign key(NoTypeAbonnement) references TypesAbonnement(No),
Remarque varchar(50)

)
print 'Création table Terrains'
create table Terrains(
No int primary key(No) not null,
Nom varchar(50) not null,
NombreTrous int not null,
Description varchar(50),
Remarque varchar(50)
)

print 'Création table PartiesJouees'
create table PartiesJouees(
IdAbonnement int foreign key(IdAbonnement) references Abonnements(Id) not null,
NoTerrain int foreign key(NoTerrain) references Terrains(No) not null,
DatePartie date not null,
Pointage int not null,
Remarque varchar(50),
constraint pk_PartieJouees primary key(IdAbonnement,NoTerrain,DatePartie)
)
print 'Création table Reabonnements'
create table Reabonnements(
IdAbonnement int foreign key(IdAbonnement) references Abonnements(Id) not null,
DateRenouvellement date not null,
Remarque varchar(50),
constraint pk_Reabonnements primary key(IdAbonnement,DateRenouvellement)
)



print 'Création table TypesEmploye'
create table TypesEmploye(
No int  primary key(No) not null,
Description varchar(50) not null,
Remarque varchar(50)
)

print 'Création table Employes'
create table Employes(
No int primary key(No) not null,
MotDePasse varchar(8) not null,
Nom varchar(50) not null,
Prenom varchar(50) not null,
Sexe varchar(1) constraint ck_sexe check (UPPER(Sexe) in ('H','F')) not null,
Age int not null,
NoCivique int not null,
Rue varchar(50) not null,
Ville varchar(50) not null,
IdProvince char(2) COLLATE Latin1_General_CS_AS constraint CK_Idprov check (IdProvince IN ('AB','BC','PE','MB','NB','NS','NU','ON','QC','SK','NL','YT','NT')) foreign key(IdProvince) references Provinces(Id) not null,
CodePostal varchar(6) not null,
Telephone varchar(10) not null,
Cellulaire varchar(10) not null,
Courriel varchar(50) not null,
SalaireHoraire int not null,
NoTypeEmploye int foreign key(NoTypeEmploye) references TypesEmploye(No) not null,
Remarque varchar(50)
) 

print 'Création table Services'
create table Services(
No int primary key(No) not null,
TypesService int not null,
NoEmploye int not null foreign key(NoEmploye) references Employes(No),
Remarque varchar(50)
)
print 'Création table Depenses'
create table Depenses(
No int primary key(No) not null,
IdAbonnement int foreign key(IdAbonnement) references Abonnements(Id) not null,
DateDepense date not null,
Montant money not null,
NoService int foreign key(NoService) references Services(No)  not null,
Remarque varchar(50)
)
print 'Création table Dependants'
create table Dependants(
Id int primary key(Id) not null,
Nom varchar(50) not null,
Prenom varchar(50) not null,
Sexe varchar(1) constraint ck_sexe1 check (UPPER(Sexe) in ('H','F')) not null,
IdAbonnement int foreign key(IdAbonnement) references Abonnements(Id) not null,
Remarque varchar(50)
)


print '=============================Remplissage des tables ==========================='

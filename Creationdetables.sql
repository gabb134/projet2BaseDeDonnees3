
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
Prix money not null,
DepensesObligatoires money not null,
Remarque varchar(50),
constraint pk_PrixDepensesAbonnements primary key(NoTypeAbonnement,Annee)
)

print 'Création table Abonnements'
create table Abonnements(
Id varchar(50) primary key(Id) not null,
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
Cellulaire varchar(10) ,
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
IdAbonnement varchar(50) foreign key(IdAbonnement) references Abonnements(Id) not null,
NoTerrain int foreign key(NoTerrain) references Terrains(No) not null,
DatePartie date not null,
Pointage int not null,
Remarque varchar(50),
constraint pk_PartieJouees primary key(IdAbonnement,NoTerrain,DatePartie)
)
print 'Création table Reabonnements'
create table Reabonnements(
IdAbonnement varchar(50) foreign key(IdAbonnement) references Abonnements(Id) not null,
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
MotDePasse varchar(50) not null,
Nom varchar(50) not null,
Prenom varchar(50) not null,
Sexe varchar(1) constraint ck_sexe check (UPPER(Sexe) in ('H','F')) not null,
Age int not null,
NoCivique int not null,
Rue varchar(50) not null,
Ville varchar(50) not null,
IdProvince char(2) COLLATE Latin1_General_CS_AS constraint CK_Idprov check (IdProvince IN ('AB','BC','PE','MB','NB','NS','NU','ON','QC','SK','NL','YT','NT')) foreign key(IdProvince) references Provinces(Id) not null,
CodePostal varchar(7) not null,
Telephone varchar(14) not null,
Cellulaire varchar(15),
Courriel varchar(50) not null,
SalaireHoraire int not null,
NoTypeEmploye int foreign key(NoTypeEmploye) references TypesEmploye(No) not null,
Remarque varchar(50)
) 

print 'Création table Services'
create table Services(
No int primary key(No) not null,
TypesService varchar(50) not null,
NoEmploye int not null foreign key(NoEmploye) references Employes(No),
Remarque varchar(50)
)
print 'Création table Depenses'
create table Depenses(
No int primary key(No) not null,
IdAbonnement varchar(50) foreign key(IdAbonnement) references Abonnements(Id) not null,
DateDepense date not null,
Montant money not null,
NoService int foreign key(NoService) references Services(No)  not null,
Remarque varchar(50)
)
print 'Création table Dependants'
create table Dependants(
Id varchar(50) primary key(Id) not null,
Nom varchar(50) not null,
Prenom varchar(50) not null,
Sexe varchar(1) constraint ck_sexe1 check (UPPER(Sexe) in ('H','F')) not null,
DateNaissance date not null,
IdAbonnement varchar(50) foreign key(IdAbonnement) references Abonnements(Id) not null,
Remarque varchar(50)
)


print '=============================Remplissage des tables ==========================='


Print  'Remplissage de la TABLE Provinces'
insert into Provinces (Id,Nom)values('AB','Alberta')
insert into Provinces (Id,Nom)values('BC','Colombie-Britanique')
insert into Provinces (Id,Nom)values('MB','Manitoba')
insert into Provinces (Id,Nom)values('NB','Nouveau-Brunswick')
insert into Provinces (Id,Nom)values('NL','Terre-Neuve et Labrador')
insert into Provinces (Id,Nom)values('NT','Territoires du Nord-Ouest')
insert into Provinces (Id,Nom)values('NS','Nouvelle-Écosse')
insert into Provinces (Id,Nom)values('NU','Nunavut')
insert into Provinces (Id,Nom)values('ON','Ontario')
insert into Provinces (Id,Nom)values('PE','Île-du-Prince-Édouard')
insert into Provinces (Id,Nom)values('QC','Québec')
insert into Provinces (Id,Nom)values('SK','Saskatchewan')
insert into Provinces (Id,Nom)values('YT','Territoire du Yukon')

Print  'Remplissage de la TABLE TypesEmploye'
insert into TypesEmploye (No,Description) values(1,'Administrateur')
insert into TypesEmploye (No,Description) values(2,'Direction')
insert into TypesEmploye (No,Description) values(3,'Propriétaire d''un club')
insert into TypesEmploye (No,Description) values(4,'Employe d''un club')
insert into TypesEmploye (No,Description) values(5,'Employé Pro-Shop')
insert into TypesEmploye (No,Description) values(6,'Employe d''un restaurant')
insert into TypesEmploye (No,Description) values(7,'Professeur de golf')




Print  'Remplissage de la TABLE Employes(le premier Employe est l''administrateur)...'
insert into Employes(No,MotDePasse,Nom,Prenom,Sexe,Age,NoCivique,Rue,Ville,IdProvince,CodePostal,Telephone,Courriel,SalaireHoraire,NoTypeEmploye) 
values(1,'Passwords%1','Marrero','Gabriel','H',21,1,'Elgin','Montreal','QC','H9H1V2','5149721014','admin@gmail.com',45,1)
insert into Employes (No,MotDePasse,Nom,Prenom,Sexe,Age,NoCivique,Rue,Ville,IdProvince,CodePostal,Telephone,Courriel,SalaireHoraire,NoTypeEmploye) 
values(2,'Passwords%1','Kouma','Cedric','H',23,1,'test','test','QC','H9H1V2','5146789876','Kouma@gmail.com',32,2)
insert into Employes(No,MotDePasse,Nom,Prenom,Sexe,Age,NoCivique,Rue,Ville,IdProvince,CodePostal,Telephone,Courriel,SalaireHoraire,NoTypeEmploye) 
values(3,'Passwords%1','Guelleh','Mohamed','H',25,1,'test','test','QC','H9H1V2','5149721014','Guelleh@gmail.com',12,3)

insert into Employes (No,MotDePasse,Nom,Prenom,Sexe,Age,NoCivique,Rue,Ville,IdProvince,CodePostal,Telephone,Courriel,SalaireHoraire,NoTypeEmploye)
values(4,'Passwords%1','Porras','Alex','H',18,1,'test','test','QC','H9H1V2','5149721014','Porras@gmail.com',32,4)
insert into Employes (No,MotDePasse,Nom,Prenom,Sexe,Age,NoCivique,Rue,Ville,IdProvince,CodePostal,Telephone,Courriel,SalaireHoraire,NoTypeEmploye)
values(5,'Passwords%1','Gariepy','Alex','H',25,1,'test','test','QC','H9H1V2','5149721014','Gariepy@gmail.com',16,5)
insert into Employes (No,MotDePasse,Nom,Prenom,Sexe,Age,NoCivique,Rue,Ville,IdProvince,CodePostal,Telephone,Courriel,SalaireHoraire,NoTypeEmploye)
values(6,'Passwords%1','Bergeron','Olivier','H',32,1,'test','test','QC','H9H1V2','5149721014','Bergeron@gmail.com',43,6)

insert into Employes (No,MotDePasse,Nom,Prenom,Sexe,Age,NoCivique,Rue,Ville,IdProvince,CodePostal,Telephone,Courriel,SalaireHoraire,NoTypeEmploye)
values(7,'Passwords%1','Leclerc','David','H',31,1,'test','test','QC','H9H1V2','5149721014','Leclerc@gmail.com',21,7)

Print  'Remplissage de la TABLE Terrains'
insert into Terrains (No,Nom,NombreTrous,Description) values(1,'terrain1',18,'ceci est le terrain 1')
insert into Terrains (No,Nom,NombreTrous,Description) values(2,'terrain2',18,'ceci est le terrain 2')
insert into Terrains (No,Nom,NombreTrous,Description) values(3,'terrain3',18,'ceci est le terrain 3')
insert into Terrains (No,Nom,NombreTrous,Description) values(4,'terrain4',9,'ceci est le terrain 4')
insert into Terrains (No,Nom,NombreTrous,Description) values(5,'terrain5',9,'ceci est le terrain 5')
insert into Terrains (No,Nom,NombreTrous,Description) values(6,'terrain6',9,'ceci est le terrain 6')


Print  'Remplissage de la TABLE TypesAbonnement'

insert into TypesAbonnement (No,Description) values(1,'Personne seule')
insert into TypesAbonnement (No,Description) values(2,'Âge d''or')
insert into TypesAbonnement (No,Description) values(3,'Couple')
insert into TypesAbonnement (No,Description) values(4,'Famille (couple + 1 enfant)')
insert into TypesAbonnement (No,Description) values(5,'Famille (couple + 2 enfants)')
insert into TypesAbonnement (No,Description) values(6,'Famille (couple + 3 enfants ou plus)')


Print  'Remplissage de la TABLE PrixDepensesAbonnements'
insert into PrixDepensesAbonnements (NoTypeAbonnement,Annee,Prix,DepensesObligatoires) values(1,2018,850,400)
insert into PrixDepensesAbonnements (NoTypeAbonnement,Annee,Prix,DepensesObligatoires) values(2,2018,500,400)
insert into PrixDepensesAbonnements (NoTypeAbonnement,Annee,Prix,DepensesObligatoires) values(3,2018,1200,700)
insert into PrixDepensesAbonnements (NoTypeAbonnement,Annee,Prix,DepensesObligatoires) values(4,2018,1700,700)
insert into PrixDepensesAbonnements (NoTypeAbonnement,Annee,Prix,DepensesObligatoires) values(5,2018,1900,700)
insert into PrixDepensesAbonnements (NoTypeAbonnement,Annee,Prix,DepensesObligatoires) values(6,2018,2100,700)


print 'Remplissage de la TABLE services'


insert into Services (No,TypesService,NoEmploye) values(1,'Magasin Pro-Shop',5)
insert into Services (No,TypesService,NoEmploye) values(2,'Restaurant',6)
insert into Services (No,TypesService,NoEmploye) values(3,'Leçon de golf',7)	

print 'Tests des tables '

select * from Employes

select * from Abonnements
select * from Dependants

select * from Reabonnements

select * from PartiesJouees


delete from Services where NoEmploye = 5
delete from Services where NoEmploye = 6
delete from Services where NoEmploye = 7

select * from Services

select * from Depenses


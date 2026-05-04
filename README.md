\# 💊 Pharmacell - Pharmacy Management System



\## 📌 Description

Pharmacell est une application de gestion de pharmacie (POS - Point of Sale) développée en C#.

Elle permet de gérer les opérations quotidiennes d’une pharmacie comme la gestion des clients, médicaments, ventes et stock.



\---



\## 🛠️ Technologies utilisées

\- C#

\- .NET Framework / Windows Forms

\- ADO.NET

\- Entity Framework

\- SQL Server



\---



\## 🧩 Modules du projet



\### 👤 Utilisateurs

\- Gestion des comptes utilisateurs

\- Authentification (login/logout)

\- Gestion des rôles



\### 🏷️ Catégories

\- Ajout / modification / suppression des catégories de médicaments



\### 👥 Clients

\- Gestion des informations clients

\- Historique des achats



\### 💊 Médicaments

\- Gestion du stock de médicaments

\- Prix, quantité, date d’expiration



\### 🧾 Ventes

\- Création de factures

\- Calcul automatique du total

\- Enregistrement des transactions



\### 📦 Commandes d’approvisionnement

\- Gestion des commandes fournisseurs

\- Suivi des livraisons



\### 🚚 Fournisseurs

\- Gestion des fournisseurs

\- Informations de contact



\### 📊 Mouvements de stock

\- Entrées et sorties de stock

\- Suivi en temps réel



\### 📜 Ordonnances

\- Gestion des prescriptions médicales



\---



\## 🧱 Architecture

Le projet est organisé en :

\- \*\*UserControls\*\* pour chaque module

\- \*\*Data Access Layer (ADO.NET / EF)\*\*

\- \*\*Base de données SQL Server\*\*



\---



\## 📊 Export et Impression



\### 📤 Export vers Excel

\- Possibilité d’exporter les données des DataGridView vers un fichier Excel

\- Utilisation pour sauvegarde ou analyse des données

\- Format compatible avec Microsoft Excel



\### 🖨️ Aperçu avant impression

\- Fonction d’aperçu avant impression des tickets de vente

\- Vérification du contenu avant impression



\### 🧾 Impression de tickets

\- Impression des reçus de vente

\- Format ticket (style caisse)

\- Affichage des détails : produits, quantités, prix, total



Le système d’impression permet :

\- Génération de tickets de caisse

\- Aperçu avant impression (Print Preview)

\- Impression directe depuis l’application

\- Format optimisé pour imprimantes thermiques





\---

\## 🚀 Fonctionnalités principales

\- CRUD complet (Create, Read, Update, Delete)

\- Gestion du stock en temps réel

\- Interface Windows Forms intuitive

\- Séparation des modules

\- Connexion base de données sécurisée

\- Export des données vers Excel depuis les DataGridView

\- Aperçu avant impression des tickets de vente

\- Impression des reçus de caisse



\---





\## 📷 Aperçu de l’application



\### 🔐 Login

!\[Login](screenshots/login.png)



\### 👤 Gestion des utilisateurs

!\[Users](screenshots/Users.png)



\### 👥 Clients

!\[Clients](screenshots/client.png)



\### 💊 Médicaments

!\[Médicaments](screenshots/médicaments.png)



\### 🔎 Recherche par nom

!\[Search](screenshots/SearchByName.png)



\### 📤 Export vers Excel

!\[Export Excel](screenshots/exportToExcel.png)



\### 🖨️ Aperçu avant impression

!\[Print Preview](screenshots/PrintPreview.png)

\---



\## 🔧 Installation

1\. Cloner le projet :

```bash

git clone https://github.com/ton-user/pharmacell.git

2\. Ouvrir le fichier .sln avec Visual Studio 2022

3\. Restaurer la base de données SQL Server

4\. Configurer la chaîne de connexion si nécessaire

5\. Lancer l’application

---
🧱 Architecture

UserControls pour chaque module

ADO.NET / Entity Framework pour l’accès aux données

Base de données SQL Server

Architecture modulaire



\----



👨‍💻 Auteur



Développé par : Otmane CHAFIK

Projet académique / formation développeur



\----



📌 Améliorations futures

Ajout d’un dashboard statistique

Export PDF des factures

Version web avec ASP.NET

Gestion multi-pharmacies

Notifications de stock faible



\---



⭐ Objectif du projet



Créer une solution complète, moderne et évolutive de gestion de pharmacie pour améliorer la gestion des ventes et du stock.


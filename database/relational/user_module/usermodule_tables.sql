-- File name    : usermodule_tables.sql
-- Description  : Create tables for user module of feria virtual.
-- Author       : Daniel García Asathor


SET ECHO OFF;
SET FEEDBACK OFF;
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
ALTER SESSION SET NLS_LANGUAGE= 'SPANISH' NLS_TERRITORY= 'Spain' NLS_CURRENCY= '$' NLS_ISO_CURRENCY= 'AMERICA' NLS_NUMERIC_CHARACTERS= '.,' NLS_CALENDAR= 'GREGORIAN' NLS_DATE_FORMAT= 'DD-MON-RR' NLS_DATE_LANGUAGE= 'SPANISH' NLS_SORT= 'BINARY';
PROMPT;
PROMPT Creating USER module TABLES.;


PROMPT - Creating PROFILE USER TABLE.;
CREATE TABLE fv_user.user_profile (
    ProfileId   NUMBER(2)    NOT NULL,
    ProfileName VARCHAR2(50) NOT NULL,
    CONSTRAINT UserProfile_PK PRIMARY KEY (ProfileId)
) TABLESPACE fv_env;


PROMPT - Creating USERS registration TABLE.;
CREATE TABLE fv_user.user_registration (
    UserId       VARCHAR2(36) NOT NULL,
    ProfileId    NUMBER(2)    NOT NULL,
    FirstName    VARCHAR2(50) NOT NULL,
    LastName     VARCHAR2(50) NOT NULL,
    Dni          VARCHAR2(20) NOT NULL,
    CreationDate DATE DEFAULT SYSDATE,
    LastUpdate   DATE,
    CONSTRAINT UserRregistration_PK PRIMARY KEY (UserId),
    CONSTRAINT UserRegistration_UserProfile_FK FOREIGN KEY (ProfileId)
        REFERENCES fv_user.user_profile (ProfileId)
) TABLESPACE fv_env;


PROMPT - Creating USER credential TABLE.;
CREATE TABLE fv_user.user_credential (
    CredentialId VARCHAR2(36)  NOT NULL,
    UserId       VARCHAR2(36)  NOT NULL,
    Username     VARCHAR2(50)  NOT NULL,
    Password     VARCHAR2(128) NOT NULL,
    Email        VARCHAR2(255) NOT NULL,
    IsActive     NUMBER(1) DEFAULT 0,
    CreationDate DATE      DEFAULT SYSDATE,
    LastUpdate   DATE,
    CONSTRAINT UserCredential_PK PRIMARY KEY (CredentialId),
    CONSTRAINT UserCredential_Registration_FK FOREIGN KEY (UserId)
        REFERENCES fv_user.user_Registration (UserId)
        ON DELETE CASCADE
) TABLESPACE fv_env;


PROMPT USER module TABLES was created.;
PROMPT;
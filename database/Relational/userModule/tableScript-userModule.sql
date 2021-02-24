-- File name    : tableScript-userModule.sql
-- Description  : Create tables for user module of feria virtual.
-- Author       : Daniel García Asathor


SET ECHO OFF;
set feedback off;
ALTER SESSION SET "_ORACLE_SCRIPT" = true;
ALTER SESSION SET NLS_LANGUAGE= 'SPANISH' NLS_TERRITORY= 'Spain' NLS_CURRENCY= '$' NLS_ISO_CURRENCY= 'AMERICA' NLS_NUMERIC_CHARACTERS= '.,' NLS_CALENDAR= 'GREGORIAN' NLS_DATE_FORMAT= 'DD-MON-RR' NLS_DATE_LANGUAGE= 'SPANISH' NLS_SORT= 'BINARY';
prompt;
prompt Creating user module tables.;


prompt - Creating profile user table.;
CREATE TABLE fv_user.user_profile
(
    ProfileId   NUMBER(2)    NOT NULL,
    ProfileName VARCHAR2(50) NOT NULL,
    constraint user_profile_pk primary key (ProfileId)
) tablespace fv_env;


prompt - Creating user credential table.;
CREATE TABLE fv_user.user_credential
(
    CredentialId varchar2(36)  NOT NULL,
    Username     varchar2(50)  not null,
    Password     varchar2(128) not null,
    Email        varchar2(255) not null,
    IsActive     number(1) default 0,
    CreationDate date      default sysdate,
    LastUpdate   date,
    constraint user_credential_pk primary key (CredentialId)
) tablespace fv_env;


prompt - Creating customer table.;
CREATE TABLE fv_user.customer
(
    CustomerId   VARCHAR2(36) NOT NULL,
    CredentialId VARCHAR2(36) NOT NULL,
    ProfileId    NUMBER(2)    NOT NULL,
    FirstName    VARCHAR2(50) NOT NULL,
    LastName     VARCHAR2(50) NOT NULL,
    Dni          VARCHAR2(20) NOT NULL,
    CreationDate date default sysdate,
    LastUpdate   date,
    constraint customer_pk primary key (CustomerId),
    constraint customer_credential_fk foreign key (CredentialId)
        references fv_user.user_credential (CredentialId),
    constraint customer_profile_fk foreign key (ProfileId)
        references fv_user.user_profile (ProfileId)
) tablespace fv_env;


prompt - Creating employee table.;
CREATE TABLE fv_user.employee
(
    EmployeeId   VARCHAR2(36) NOT NULL,
    CredentialId VARCHAR2(36) NOT NULL,
    ProfileId    NUMBER(2)    NOT NULL,
    FirstName    VARCHAR2(50) NOT NULL,
    LastName     VARCHAR2(50) NOT NULL,
    CreationDate date default sysdate,
    LastUpdate   date,
    constraint employee_pk primary key (EmployeeId),
    constraint employee_credential_fk foreign key (CredentialId)
        references fv_user.user_credential (CredentialId),
    constraint employee_profile_fk foreign key (ProfileId)
        references fv_user.user_profile (ProfileId)
) tablespace fv_env;


prompt User module tables was created.;
prompt;
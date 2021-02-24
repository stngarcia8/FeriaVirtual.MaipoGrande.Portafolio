-- File name    : Relational_InitTablespace.sql
-- Description  : Create user and tablespace for FeriaVirtual tablespace.
-- Author       : Daniel García Asathor


SET ECHO OFF;
set feedback off;
ALTER SESSION SET "_ORACLE_SCRIPT" = true;
ALTER SESSION SET NLS_LANGUAGE= 'SPANISH' NLS_TERRITORY= 'Spain' NLS_CURRENCY= '$' NLS_ISO_CURRENCY= 'AMERICA' NLS_NUMERIC_CHARACTERS= '.,' NLS_CALENDAR= 'GREGORIAN' NLS_DATE_FORMAT= 'DD-MON-RR' NLS_DATE_LANGUAGE= 'SPANISH' NLS_SORT= 'BINARY';
prompt Starting the session configuration for the FeriaVirtual tablespace.;


prompt - Deleting old user  and tablespace.;
DROP USER fv_user CASCADE;
DROP tablespace fv_env INCLUDING CONTENTS AND DATAFILES CASCADE CONSTRAINTS;


prompt - Creating user and tablespace for FeriaVirtual.;
CREATE TABLESPACE fv_env DATAFILE 'fv_env.dbf' SIZE 500 M autoextend ON;
CREATE USER fv_user IDENTIFIED BY fv_pwd DEFAULT TABLESPACE fv_env temporary tablespace temp;


prompt - Assign privileges to user.;
GRANT CREATE SESSION TO fv_user;
GRANT RESOURCE TO fv_user;
GRANT CREATE VIEW TO fv_user;


prompt - Define tablespace for FeriaVirtual user.;
ALTER USER fv_user QUOTA UNLIMITED ON fv_env;


prompt Session settings for FeriaVirtual tablespace was completed.;
COMMIT;

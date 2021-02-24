-- File name    : Dimensional_InitTablespace.sql
-- Description  : Create user and tablespace for FeriaVirtual dimensional tablespace.
-- Author       : Daniel García Asathor


SET ECHO OFF;
set feedback off;
ALTER SESSION SET "_ORACLE_SCRIPT" = true;
ALTER SESSION SET NLS_LANGUAGE= 'SPANISH' NLS_TERRITORY= 'Spain' NLS_CURRENCY= '$' NLS_ISO_CURRENCY= 'AMERICA' NLS_NUMERIC_CHARACTERS= '.,' NLS_CALENDAR= 'GREGORIAN' NLS_DATE_FORMAT= 'DD-MON-RR' NLS_DATE_LANGUAGE= 'SPANISH' NLS_SORT= 'BINARY';
prompt Starting the session configuration for the FeriaVirtual dimensional tablespace.;


prompt - Deleting old user  and tablespace.;
DROP USER fv_dimuser CASCADE;
DROP tablespace fv_dimenv INCLUDING CONTENTS AND DATAFILES CASCADE CONSTRAINTS;


prompt - Creating user and tablespace for FeriaVirtual.;
CREATE TABLESPACE fv_dimenv DATAFILE 'fv_dimenv.dbf' SIZE 500 M autoextend ON;
CREATE USER fv_dimuser IDENTIFIED BY fv_dimpwd DEFAULT TABLESPACE fv_dimenv temporary tablespace temp;


prompt - Assign privileges to user.;
GRANT CREATE SESSION TO fv_dimuser;
GRANT RESOURCE TO fv_dimuser;
GRANT CREATE VIEW TO fv_dimuser;


prompt - Define dimensional tablespace for FeriaVirtual user.;
ALTER USER fv_dimuser QUOTA UNLIMITED ON fv_dimenv;


prompt Session settings for FeriaVirtual dimensional tablespace was completed.;
COMMIT;

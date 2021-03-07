-- File name    : usermodule_tables.sql
-- Description  : Create common tables  for relational tablespace.
-- Author       : Daniel García Asathor


SET ECHO OFF;
set feedback off;
ALTER SESSION SET "_ORACLE_SCRIPT" = true;
ALTER SESSION SET NLS_LANGUAGE= 'SPANISH' NLS_TERRITORY= 'Spain' NLS_CURRENCY= '$' NLS_ISO_CURRENCY= 'AMERICA' NLS_NUMERIC_CHARACTERS= '.,' NLS_CALENDAR= 'GREGORIAN' NLS_DATE_FORMAT= 'DD-MON-RR' NLS_DATE_LANGUAGE= 'SPANISH' NLS_SORT= 'BINARY';
prompt;
prompt Creating common tables.;


prompt - Creating settings table.;
CREATE TABLE fv_user.setting
(
    RowsPerPage NUMBER(3) DEFAULT 10
) TABLESPACE fv_env;


prompt Common tables was created.;
prompt;
-- File name    : common_populate.sql
-- Description  : Populate common  tables.
-- Author       : Daniel García Asathor


SET ECHO OFF;
set feedback off;
ALTER SESSION SET "_ORACLE_SCRIPT" = true;
ALTER SESSION SET NLS_LANGUAGE= 'SPANISH' NLS_TERRITORY= 'Spain' NLS_CURRENCY= '$' NLS_ISO_CURRENCY= 'AMERICA' NLS_NUMERIC_CHARACTERS= '.,' NLS_CALENDAR= 'GREGORIAN' NLS_DATE_FORMAT= 'DD-MON-RR' NLS_DATE_LANGUAGE= 'SPANISH' NLS_SORT= 'BINARY';
prompt Starting to populate user module tables for initial execution.;


prompt - Inserting default settings.;
INSERT INTO
    fv_user.setting (RowsPerPage)
VALUES
    (10);

prompt Populate common tables was finished.;
prompt;



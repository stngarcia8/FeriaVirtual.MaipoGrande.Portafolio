-- File name    : dimensional_main.sql
-- Description  : Start the execution of dimensional tablespace script for FeriaVirtual project.
-- Author       : Daniel García Asathor


SET ECHO OFF;
set feedback off;
clear screen;
prompt Feria virtual.;
prompt --------------;
prompt Creating FeriaVirtual dimensional tablespace.;
prompt 2020-2021, Daniel García Asathor.;
prompt ----------------------------------------;
prompt;


prompt Initializing FeriaVirtual dimensional tablespace.;
ALTER SESSION SET "_ORACLE_SCRIPT" = true;
ALTER SESSION SET NLS_LANGUAGE= 'SPANISH' NLS_TERRITORY= 'Spain' NLS_CURRENCY= '$' NLS_ISO_CURRENCY= 'AMERICA' NLS_NUMERIC_CHARACTERS= '.,' NLS_CALENDAR= 'GREGORIAN' NLS_DATE_FORMAT= 'DD-MON-RR' NLS_DATE_LANGUAGE= 'SPANISH' NLS_SORT= 'BINARY';
prompt;

-- Execute dimensional tablespace scripts;
@/script_files/dimensional/dimensional_init.sql;

prompt Dimensional FeriaVirtual tablespace is ready to use.;
prompt;

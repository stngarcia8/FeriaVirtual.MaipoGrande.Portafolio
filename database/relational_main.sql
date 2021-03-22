-- File name    : relational_main.sql
-- Description  : Start the execution of tablespace script for FeriaVirtual project.
-- Author       : Daniel García Asathor


SET ECHO OFF;
set feedback off;
clear screen;
prompt Feria virtual.;
prompt --------------;
prompt Creating FeriaVirtual tablespace.;
prompt 2020-2021, Daniel García Asathor.;
prompt ----------------------------------------;
prompt;


prompt Initializing FeriaVirtual tablespace.;
ALTER SESSION SET "_ORACLE_SCRIPT" = true;
ALTER SESSION SET NLS_LANGUAGE= 'SPANISH' NLS_TERRITORY= 'Spain' NLS_CURRENCY= '$' NLS_ISO_CURRENCY= 'AMERICA' NLS_NUMERIC_CHARACTERS= '.,' NLS_CALENDAR= 'GREGORIAN' NLS_DATE_FORMAT= 'DD-MON-RR' NLS_DATE_LANGUAGE= 'SPANISH' NLS_SORT= 'BINARY';
prompt;

-- Excecute relational tablespace script
@/script_files/relational/relational_init.sql;

-- Excecute common script
@/script_files/relational/common/common_tables.sql;
@/script_files/relational/common/common_procedures.sql;
@/script_files/relational/common/common_populate.sql;

-- user module objects.;
@/script_files/relational/user_module/usermodule_tables.sql;
@/script_files/relational/user_module/usermodule_views.sql;
@/script_files/relational/user_module/usermodule_procedures.sql;
@/script_files/relational/user_module/usermodule_populate.sql;


prompt FeriaVirtual tablespace is ready to use.;
prompt;

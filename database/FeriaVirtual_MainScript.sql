-- File name    : FeriaVirtual_MainScript.sql
-- Description  : Start the execution of tablespaces script for FeriaVirtual project.
-- Author       : Daniel García Asathor


SET ECHO OFF;
set feedback off;
clear screen;
prompt Feria virtual.;
prompt --------------;
prompt Creating FeriaVirtual tablespaces.;
prompt 2020-2021, Daniel García Asathor.;
prompt ----------------------------------------;
prompt;


prompt Initializing FeriaVirtual database.;
ALTER SESSION SET "_ORACLE_SCRIPT" = true;
ALTER SESSION SET NLS_LANGUAGE= 'SPANISH' NLS_TERRITORY= 'Spain' NLS_CURRENCY= '$' NLS_ISO_CURRENCY= 'AMERICA' NLS_NUMERIC_CHARACTERS= '.,' NLS_CALENDAR= 'GREGORIAN' NLS_DATE_FORMAT= 'DD-MON-RR' NLS_DATE_LANGUAGE= 'SPANISH' NLS_SORT= 'BINARY';
prompt;

-- Excecute application script
-- @/script_files/initDbScript.sql;
-- @/script_files/applicationScript.sql;

-- Execute user module script
-- @/script_files/userModule/tableScript-userModule.sql;
-- @/script_files/userModule/sprocScript-userModule.sql;
-- @/script_files/userModule/populScript-userModule.sql;

-- @/script_files/fkeysScript.sql;
-- @/script_files/pkgsScript.sql;
-- @/script_files/sprocScript.sql;
-- @/script_files/viewScript.sql;
-- @/script_files/viewEtlScript.sql;
-- @/script_files/populScript.sql;
-- @/script_files/normScript.sql;


prompt FeriaVirtual tablespaces are ready to use.;
prompt;

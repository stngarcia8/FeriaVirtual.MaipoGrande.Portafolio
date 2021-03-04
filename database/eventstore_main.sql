-- File name    : EventStore_mainScript.sql
-- Description  : Start the execution of database script for FeriaVirtual events.
-- Author       : Daniel García Asathor


SET ECHO OFF;
set feedback off;
clear screen;
prompt Feria virtual.;
prompt --------------;
prompt Creating FeriaVirtual event store tablespace.;
prompt 2020-2021, Daniel García Asathor.;
prompt ----------------------------------------;
prompt;


prompt Initializing FeriaVirtual events tablespace.;
ALTER SESSION SET "_ORACLE_SCRIPT" = true;
ALTER SESSION SET NLS_LANGUAGE= 'SPANISH' NLS_TERRITORY= 'Spain' NLS_CURRENCY= '$' NLS_ISO_CURRENCY= 'AMERICA' NLS_NUMERIC_CHARACTERS= '.,' NLS_CALENDAR= 'GREGORIAN' NLS_DATE_FORMAT= 'DD-MON-RR' NLS_DATE_LANGUAGE= 'SPANISH' NLS_SORT= 'BINARY';
prompt;

-- Excecute event store script
@/script_files/event_store/eventstore_init.sql;
@/script_files/event_store/eventstore_objects.sql;

prompt FeriaVirtual events tablespace is ready to use.;
prompt;

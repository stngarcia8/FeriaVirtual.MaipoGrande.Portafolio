-- File name    : eventstore_init.sql
-- Description  : Create user and tablespace for FeriaVirtual event store.
-- Author       : Daniel García Asathor


SET ECHO OFF;
set feedback off;
ALTER SESSION SET "_ORACLE_SCRIPT" = true;
ALTER SESSION SET NLS_LANGUAGE= 'SPANISH' NLS_TERRITORY= 'Spain' NLS_CURRENCY= '$' NLS_ISO_CURRENCY= 'AMERICA' NLS_NUMERIC_CHARACTERS= '.,' NLS_CALENDAR= 'GREGORIAN' NLS_DATE_FORMAT= 'DD-MON-RR' NLS_DATE_LANGUAGE= 'SPANISH' NLS_SORT= 'BINARY';
prompt Starting the session configuration for the FeriaVirtual event store tablespace.;


prompt - Creating user and tablespace for event store.;
@/script_files/event_store/eventstore_clean.sql;
CREATE TABLESPACE fv_event DATAFILE 'fv_event.dbf' SIZE 500 M autoextend ON;
CREATE USER fv_eventuser IDENTIFIED BY fv_eventpwd DEFAULT TABLESPACE fv_event temporary tablespace temp;


prompt - Assign privileges to user.;
GRANT CREATE SESSION TO fv_eventuser;
GRANT RESOURCE TO fv_eventuser;
GRANT CREATE VIEW TO fv_eventuser;


prompt - Define tablespace for event store user.;
ALTER USER fv_eventuser QUOTA UNLIMITED ON fv_event;

prompt Session settings for FeriaVirtual event store tablespace was completed.;
COMMIT;

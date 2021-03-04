-- File name    : eventstore_clean.sql
-- Description  : Delete user and tablespace event store.
-- Author       : Daniel García Asathor


SET ECHO OFF;
set feedback off;
ALTER SESSION SET "_ORACLE_SCRIPT" = true;


prompt - Droping old user  and tablespace.;
DROP USER fv_eventuser CASCADE;
DROP tablespace fv_event INCLUDING CONTENTS AND DATAFILES CASCADE CONSTRAINTS;

-- File name    : relational_clean.sql
-- Description  : Delete user and relational tablespace.
-- Author       : Daniel García Asathor


SET ECHO OFF;
set feedback off;
ALTER SESSION SET "_ORACLE_SCRIPT" = true;


prompt - Droping old user and tablespace.;
DROP USER fv_user CASCADE;
DROP tablespace fv_env INCLUDING CONTENTS AND DATAFILES CASCADE CONSTRAINTS;

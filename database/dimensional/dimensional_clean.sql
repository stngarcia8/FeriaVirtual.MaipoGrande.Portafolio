-- File name    : dimensional_clean.sql
-- Description  : Delete dimensional tablespace and user.
-- Author       : Daniel García Asathor


SET ECHO OFF;
set feedback off;
ALTER SESSION SET "_ORACLE_SCRIPT" = true;

prompt - Droping old user and tablespace.;
DROP USER fv_dimuser CASCADE;
DROP tablespace fv_dimenv INCLUDING CONTENTS AND DATAFILES CASCADE CONSTRAINTS;


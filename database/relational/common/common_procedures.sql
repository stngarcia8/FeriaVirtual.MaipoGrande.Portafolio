-- File name    : common_procedures.sql
-- Description  : Create common stored procedures forferia virtual.
-- Author       : Daniel García Asathor


SET ECHO OFF;
SET feedback OFF;
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
ALTER SESSION SET NLS_LANGUAGE= 'SPANISH' NLS_TERRITORY= 'Spain' NLS_CURRENCY= '$' NLS_ISO_CURRENCY= 'AMERICA' NLS_NUMERIC_CHARACTERS= '.,' NLS_CALENDAR= 'GREGORIAN' NLS_DATE_FORMAT= 'DD-MON-RR' NLS_DATE_LANGUAGE= 'SPANISH' NLS_SORT= 'BINARY';
prompt Creating user modules stored procedures.;


prompt - Creating pagination functions;
prompt   - fn_start_pagination;
CREATE OR REPLACE FUNCTION fv_user.fn_start_pagination(
    pPageNumber NUMBER
) RETURN NUMBER IS
    vRowsPerPage NUMBER;
    vStartValue  NUMBER;
BEGIN
    SELECT RowsPerPage
    INTO vRowsPerPage
    FROM fv_user.setting;

    vStartValue := trunc(
        ((pPageNumber * vRowsPerPage) - vRowsPerPage)
        );

    RETURN vStartValue;
END fn_start_pagination;
/

prompt   - fn_end_pagination;
CREATE OR REPLACE FUNCTION fv_user.fn_end_pagination(
    pPageNumber NUMBER
) RETURN NUMBER IS
    vEndValue    NUMBER;
BEGIN
    SELECT RowsPerPage
    INTO vEndValue
    FROM fv_user.setting;

    RETURN vEndValue;
END fn_end_pagination;
/


prompt User modules stored PROCEDURE was created.;
prompt;
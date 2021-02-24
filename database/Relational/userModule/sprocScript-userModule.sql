-- File name    : sprocScript-userModule.sql
-- Description  : Create user module stored procedures forferia virtual.
-- Author       : Daniel García Asathor


SET ECHO OFF;
SET feedback OFF;
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
ALTER SESSION SET NLS_LANGUAGE= 'SPANISH' NLS_TERRITORY= 'Spain' NLS_CURRENCY= '$' NLS_ISO_CURRENCY= 'AMERICA' NLS_NUMERIC_CHARACTERS= '.,' NLS_CALENDAR= 'GREGORIAN' NLS_DATE_FORMAT= 'DD-MON-RR' NLS_DATE_LANGUAGE= 'SPANISH' NLS_SORT= 'BINARY';
prompt Creating user modules stored procedures.;


prompt - Creating credentials stored procedures.;
CREATE OR REPLACE PROCEDURE fv_user.sp_add_credential(
    pCredentialId varchar2,
    pUsername varchar2,
    pPassword varchar2,
    pEmail varchar2,
    pIsActive number
) IS
BEGIN
    INSERT INTO fv_user.user_Credential
    (CredentialId, Username, Password, Email, IsActive)
    VALUES (pCredentialId, pUsername, pPassword, pEmail, pIsActive);
END sp_add_credential;
/

CREATE OR REPLACE PROCEDURE fv_user.sp_modify_credential(
    pCredentialId varchar2,
    pUsername varchar2,
    pPassword varchar2,
    pEmail varchar2,
    pIsActive number
) IS
BEGIN
    UPDATE fv_user.user_Credential
    SET Username   = pUsername,
        Password   = pPassword,
        Email= pEmail,
        Isactive= pIsActive,
        LastUpdate = SYSDATE
    WHERE CredentialId = pCredentialId;
END sp_modify_credential;
/

CREATE OR REPLACE PROCEDURE fv_user.sp_enable_user(
    pCredentialId varchar2
) IS
BEGIN
    UPDATE fv_user.user_credential
    SET IsActive= 1,
        LastUpdate = SYSDATE
    WHERE CredentialId = pCredentialId;
END sp_enable_user;
/

CREATE OR REPLACE PROCEDURE fv_user.sp_disable_user(
    pCredentialId varchar2
) IS
BEGIN
    UPDATE fv_user.user_credential
    SET IsActive= 0,
        LastUpdate = SYSDATE
    WHERE CredentialId = pCredentialId;
END sp_disable_user;
/


prompt - Creating employee stored procedures.;
CREATE OR REPLACE PROCEDURE fv_user.sp_add_employee(
    pEmployeeId varchar2,
    pCredentialId varchar2,
    pProfileId number,
    pFirstName varchar2,
    pLastName varchar2
) IS
BEGIN
    INSERT INTO fv_user.employee
        (EmployeeId, CredentialId, ProfileId, FirstName, LastName)
    VALUES (pEmployeeId, pCredentialId, pProfileId, pFirstName, pLastName);
END sp_add_employee;
/

CREATE OR REPLACE PROCEDURE fv_user.sp_modify_employee(
    pEmployeeId varchar2,
    pCredentialId varchar2,
    pProfileId number,
    pFirstName varchar2,
    pLastName varchar2
) IS
BEGIN
    UPDATE fv_user.employee
    SET ProfileId  = pProfileId,
        FirstName  = pFirstName,
        LastName=pLastName,
        LastUpdate = SYSDATE
    WHERE EmployeeId = pEmployeeId;
END sp_modify_employee;
/


prompt User modules stored PROCEDURE was created.;
prompt;
-- File name    : usermodule_procedures.sql
-- Description  : Create user module stored procedures forferia virtual.
-- Author       : Daniel García Asathor


SET ECHO OFF;
SET feedback OFF;
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
ALTER SESSION SET NLS_LANGUAGE= 'SPANISH' NLS_TERRITORY= 'Spain' NLS_CURRENCY= '$' NLS_ISO_CURRENCY= 'AMERICA' NLS_NUMERIC_CHARACTERS= '.,' NLS_CALENDAR= 'GREGORIAN' NLS_DATE_FORMAT= 'DD-MON-RR' NLS_DATE_LANGUAGE= 'SPANISH' NLS_SORT= 'BINARY';
prompt Creating user modules stored procedures.;


prompt - Creating credentials stored procedures.;
prompt   - sp_add_credential;
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

prompt   - sp_update_credential;
CREATE OR REPLACE PROCEDURE fv_user.sp_update_credential(
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
END sp_update_credential;
/


prompt - Creating users stored procedures.;
prompt   - sp_add_user;
CREATE OR REPLACE PROCEDURE fv_user.sp_add_user(
    pUserId varchar2,
    pCredentialId varchar2,
    pProfileId number,
    pFirstName varchar2,
    pLastName varchar2,
    pDni varchar2
) IS
BEGIN
    INSERT INTO fv_user.user_registration
        (UserId, CredentialId, ProfileId, FirstName, LastName, Dni)
    VALUES (pUserId, pCredentialId, pProfileId, pFirstName, pLastName, pDni);
END sp_add_user;
/

prompt   - sp_update_user;
CREATE OR REPLACE PROCEDURE fv_user.sp_update_user(
    pUserId VARCHAR2,
    pCredentialId VARCHAR2,
    pProfileId NUMBER,
    pFirstName VARCHAR2,
    pLastName VARCHAR2,
    pDni VARCHAR2
) IS
BEGIN
    UPDATE fv_user.user_registration
    SET ProfileId  = pProfileId,
        FirstName  = pFirstName,
        LastName=pLastName,
        Dni=pDni,
        LastUpdate = SYSDATE
    WHERE UserId = pUserId;
END sp_update_user;
/

prompt   - sp_enable_user;
CREATE OR REPLACE PROCEDURE fv_user.sp_enable_user(
    pUserId VARCHAR2
) AS
    vCredentialId fv_user.user_registration.CredentialId%TYPE;
BEGIN
    SELECT CredentialId
    INTO vCredentialId
    FROM fv_user.user_registration
    WHERE UserId = pUserId;

    UPDATE fv_user.user_credential
    SET IsActive= 1,
        LastUpdate = SYSDATE
    WHERE CredentialId = vCredentialId;

    UPDATE fv_user.user_registration
    SET LastUpdate = SYSDATE
    WHERE UserId = pUserId;
END sp_enable_user;
/

prompt   - sp_disable_user;
CREATE OR REPLACE PROCEDURE fv_user.sp_disable_user(
    pUserId VARCHAR2
) AS
    vCredentialId fv_user.user_registration.CredentialId%TYPE;
BEGIN
    SELECT CredentialId
    INTO vCredentialId
    FROM fv_user.user_registration
    WHERE UserId = pUserId;

    UPDATE fv_user.user_credential
    SET IsActive= 0,
        LastUpdate = SYSDATE
    WHERE CredentialId = vCredentialId;

    UPDATE fv_user.user_registration
    SET LastUpdate = SYSDATE
    WHERE UserId = pUserId;
END sp_disable_user;
/

prompt User modules stored PROCEDURE was created.;
prompt;
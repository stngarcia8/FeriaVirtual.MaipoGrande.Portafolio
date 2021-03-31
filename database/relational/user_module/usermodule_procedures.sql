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
    pUsername     varchar2,
    pPassword     varchar2,
    pEmail        varchar2,
    pIsActive     number
) IS
BEGIN
    INSERT INTO
        fv_user.user_Credential
        (CredentialId, Username, Password, Email, IsActive)
    VALUES (pCredentialId, pUsername, pPassword, pEmail, pIsActive);
END sp_add_credential;
/

prompt   - sp_update_credential;
CREATE OR REPLACE PROCEDURE fv_user.sp_update_credential(
    pCredentialId varchar2,
    pUsername     varchar2,
    pPassword     varchar2,
    pEmail        varchar2,
    pIsActive     number
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
    pUserId       varchar2,
    pCredentialId varchar2,
    pProfileId    number,
    pFirstName    varchar2,
    pLastName     varchar2,
    pDni          varchar2
) IS
BEGIN
    INSERT INTO
        fv_user.user_registration
        (UserId, CredentialId, ProfileId, FirstName, LastName, Dni)
    VALUES (pUserId, pCredentialId, pProfileId, pFirstName, pLastName, pDni);
END sp_add_user;
/

prompt   - sp_update_user;
CREATE OR REPLACE PROCEDURE fv_user.sp_update_user(
    pUserId       VARCHAR2,
    pCredentialId VARCHAR2,
    pProfileId    NUMBER,
    pFirstName    VARCHAR2,
    pLastName     VARCHAR2,
    pDni          VARCHAR2
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

prompt   - sp_get_user;
CREATE OR REPLACE PROCEDURE fv_user.sp_get_user(
    pUserId      VARCHAR2,
    pResults OUT SYS_REFCURSOR
) IS
BEGIN
    OPEN pResults FOR
        SELECT *
        FROM fv_user.vw_users
        WHERE UserId = pUserId;
END sp_get_user;
/


prompt   - sp_get_allusers;
CREATE OR REPLACE PROCEDURE fv_user.sp_get_allusers(
    pPageNumber  NUMBER DEFAULT 0,
    pResults OUT SYS_REFCURSOR
) AS
    vStart NUMBER;
    vEnd   NUMBER;
BEGIN
    IF pPageNumber > 0 THEN

        vStart := fn_start_pagination(pPageNumber);
        vEnd := fn_end_pagination(pPageNumber);

        OPEN pResults FOR
            SELECT UserId,
                   FirstName || ' ' || LastName AS FullName,
                Dni, ProfileName, Username, Email, UserStatus
            FROM fv_user.vw_users
            OFFSET vStart ROWS FETCH NEXT vEnd ROWS ONLY;
    ELSE

        OPEN pResults FOR
            SELECT UserId,
                   FirstName || ' ' || LastName AS FullName,
                   Dni, ProfileName, Username, Email, UserStatus
            FROM fv_user.vw_users;

    END IF;
END sp_get_allusers;
/


prompt   - sp_count_allusers;
CREATE OR REPLACE PROCEDURE fv_user.sp_count_allusers(
    pResults OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN pResults FOR
        SELECT COUNT(*) AS Total
        FROM fv_user.user_registration
        WHERE ProfileId > 2;
END sp_count_allusers;
/


prompt   - sp_get_employee;
CREATE OR REPLACE PROCEDURE fv_user.sp_get_employee(
    pUserId      VARCHAR2,
    pResults OUT SYS_REFCURSOR
) IS
BEGIN
    OPEN pResults FOR
        SELECT *
        FROM fv_user.vw_employees
        WHERE UserId = pUserId;
END sp_get_employee;
/


prompt   - sp_get_allemployees;
CREATE OR REPLACE PROCEDURE fv_user.sp_get_allemployees(
    pPageNumber  NUMBER DEFAULT 0,
    pResults OUT SYS_REFCURSOR
) AS
    vStart NUMBER;
    vEnd   NUMBER;
BEGIN
    IF pPageNumber > 0 THEN

        vStart := fn_start_pagination(pPageNumber);
        vEnd := fn_end_pagination(pPageNumber);

        OPEN pResults FOR
            SELECT UserId,
                   FirstName || ' ' || LastName AS FullName,
                   Dni, ProfileName, Username, Email, UserStatus
            FROM fv_user.vw_employees
            OFFSET vStart ROWS FETCH NEXT vEnd ROWS ONLY;
    ELSE

        OPEN pResults FOR
            SELECT UserId,
                   FirstName || ' ' || LastName AS FullName,
                   Dni, ProfileName, Username, Email, UserStatus
            FROM fv_user.vw_employees;

    END IF;
END sp_get_allemployees;
/


prompt   - sp_count_allemployees;
CREATE OR REPLACE PROCEDURE fv_user.sp_count_allemployees(
    pResults OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN pResults FOR
        SELECT COUNT(*) AS Total
        FROM fv_user.user_registration
        WHERE ProfileId < 3;
END sp_count_allemployees;
/


prompt   - sp_signin_user;
CREATE OR REPLACE PROCEDURE fv_user.sp_signin_user(
    pUsername    VARCHAR2,
    pPassword    VARCHAR2,
    pResults OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN pResults FOR
        SELECT FirstName || ' ' || LastName AS FullName,
               Dni, Email, ProfileId, IsActive
        FROM fv_user.vw_users
        WHERE Username = pUsername AND
                Password = pPassword;
END sp_signin_user;
/


prompt User modules stored PROCEDURE was created.;
prompt;
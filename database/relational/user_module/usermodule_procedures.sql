-- File name    : usermodule_procedures.sql
-- Description  : Create user module stored procedures forferia virtual.
-- Author       : Daniel García Asathor


SET ECHO OFF;
SET feedback OFF;
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
ALTER SESSION SET NLS_LANGUAGE= 'SPANISH' NLS_TERRITORY= 'Spain' NLS_CURRENCY= '$' NLS_ISO_CURRENCY= 'AMERICA' NLS_NUMERIC_CHARACTERS= '.,' NLS_CALENDAR= 'GREGORIAN' NLS_DATE_FORMAT= 'DD-MON-RR' NLS_DATE_LANGUAGE= 'SPANISH' NLS_SORT= 'BINARY';
prompt Creating USER modules stored procedures.;


prompt - Creating credentials stored procedures.;
prompt   - sp_add_credential;
CREATE OR REPLACE PROCEDURE fv_user.sp_add_credential(
    pCredentialId VARCHAR2,
    pUserId       VARCHAR2,
    pUsername     VARCHAR2,
    pPassword     VARCHAR2,
    pEmail        VARCHAR2,
    pIsActive     NUMBER
) IS
BEGIN
    INSERT INTO fv_user.user_Credential
        (CredentialId, UserId, Username, Password, Email, IsActive)
    VALUES (pCredentialId, pUserId, pUsername, pPassword, pEmail, pIsActive);
END sp_add_credential;
/


prompt   - sp_update_credential;
CREATE OR REPLACE PROCEDURE fv_user.sp_update_credential(
    pUserId   VARCHAR2,
    pUsername VARCHAR2,
    pEmail    VARCHAR2
) IS
BEGIN
    UPDATE fv_user.user_Credential
    SET Username   = pUsername,
        Email= pEmail,
        LastUpdate = SYSDATE
    WHERE UserId = pUserId;
END sp_update_credential;
/


prompt - Creating USERS stored procedures.;
prompt   - sp_add_user;
CREATE OR REPLACE PROCEDURE fv_user.sp_add_user(
    pUserId    VARCHAR2,
    pProfileId NUMBER,
    pFirstName VARCHAR2,
    pLastName  VARCHAR2,
    pDni       VARCHAR2
) IS
BEGIN
    INSERT INTO fv_user.user_registration
        (UserId, ProfileId, FirstName, LastName, Dni)
    VALUES (pUserId, pProfileId, pFirstName, pLastName, pDni);
END sp_add_user;
/


prompt   - sp_update_user;
CREATE OR REPLACE PROCEDURE fv_user.sp_update_user(
    pUserId    VARCHAR2,
    pProfileId NUMBER,
    pFirstName VARCHAR2,
    pLastName  VARCHAR2,
    pDni       VARCHAR2
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
BEGIN
    UPDATE fv_user.user_credential
    SET IsActive= 1,
        LastUpdate = SYSDATE
    WHERE UserId = pUserId;

    UPDATE fv_user.user_registration
    SET LastUpdate = SYSDATE
    WHERE UserId = pUserId;
END sp_enable_user;
/


prompt   - sp_disable_user;
CREATE OR REPLACE PROCEDURE fv_user.sp_disable_user(
    pUserId VARCHAR2
) AS
BEGIN
    UPDATE fv_user.user_credential
    SET IsActive= 0,
        LastUpdate = SYSDATE
    WHERE UserId = pUserId;

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
    pLimit       NUMBER DEFAULT 0,
    pOffset      NUMBER DEFAULT 0,
    pResults OUT SYS_REFCURSOR
) AS
BEGIN
    IF pLimit > 0 THEN
        OPEN pResults FOR
            SELECT UserId,
                   FirstName || ' ' || LastName AS FullName,
                   Dni, ProfileName, Username, Email, UserStatus
            FROM fv_user.vw_users
            OFFSET pOffset ROWS FETCH NEXT pLimit ROWS ONLY;

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
        WHERE ProfileId IN (3, 4, 5, 6);
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
    pLimit       NUMBER DEFAULT 0,
    pOffset      NUMBER DEFAULT 0,
    pResults OUT SYS_REFCURSOR
) AS
BEGIN
    IF pLimit > 0 THEN
        OPEN pResults FOR
            SELECT UserId,
                   FirstName || ' ' || LastName AS FullName,
                   Dni, ProfileName, Username, Email, UserStatus
            FROM fv_user.vw_employees
            OFFSET pOffset ROWS FETCH NEXT pLimit ROWS ONLY;

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
        WHERE ProfileId IN (1, 2);
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
        FROM fv_user.vw_allusers
        WHERE Username = pUsername AND
              Password = pPassword;
END sp_signin_user;
/


prompt   - sp_check_createuser_rules;
CREATE OR REPLACE PROCEDURE fv_user.sp_check_createuser_rules(
    pUsername    VARCHAR2,
    pDni         VARCHAR2,
    pEmail       VARCHAR2,
    pResults OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN pResults FOR
        SELECT (
                   SELECT CASE COUNT(*)
                              WHEN 0 THEN 0
                                     ELSE 1
                          END
                   FROM fv_user.user_credential
                   WHERE Username = pUsername) AS UsernameRegistered,
               (
                   SELECT CASE COUNT(*)
                              WHEN 0 THEN 0
                                     ELSE 1
                          END
                   FROM fv_user.user_registration
                   WHERE Dni = pDni) AS DniRegistered,
               (
                   SELECT CASE COUNT(*)
                              WHEN 0 THEN 0
                                     ELSE 1
                          END
                   FROM fv_user.user_credential
                   WHERE Email = pEmail) AS EmailRegistered
        FROM dual;
END sp_check_createuser_rules;
/


prompt   - sp_check_updateuser_rules;
CREATE OR REPLACE PROCEDURE fv_user.sp_check_updateuser_rules(
    pUserId      VARCHAR2,
    pUsername    VARCHAR2,
    pDni         VARCHAR2,
    pEmail       VARCHAR2,
    pResults OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN pResults FOR
        SELECT (
                   SELECT CASE COUNT(*)
                              WHEN 0 THEN 0
                                     ELSE 1
                          END
                   FROM fv_user.user_credential
                   WHERE Username = pUsername AND UserId <> pUserId) AS UsernameRegistered,
               (
                   SELECT CASE COUNT(*)
                              WHEN 0 THEN 0
                                     ELSE 1
                          END
                   FROM fv_user.user_registration
                   WHERE Dni = pDni AND UserId <> pUserId) AS DniRegistered,
               (
                   SELECT CASE COUNT(*)
                              WHEN 0 THEN 0
                                     ELSE 1
                          END
                   FROM fv_user.user_credential
                   WHERE Email = pEmail AND UserId <> pUserId) AS EmailRegistered
        FROM dual;
END sp_check_updateuser_rules;
/


prompt USER modules stored PROCEDURE was created.;
prompt;
-- File name    : usermodule_views.sql
-- Description  : Create user module views for feria virtual.
-- Author       : Daniel García Asathor


SET ECHO OFF;
SET FEEDBACK OFF;
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
ALTER SESSION SET NLS_LANGUAGE= 'SPANISH' NLS_TERRITORY= 'Spain' NLS_CURRENCY= '$' NLS_ISO_CURRENCY= 'AMERICA' NLS_NUMERIC_CHARACTERS= '.,' NLS_CALENDAR= 'GREGORIAN' NLS_DATE_FORMAT= 'DD-MON-RR' NLS_DATE_LANGUAGE= 'SPANISH' NLS_SORT= 'BINARY';
PROMPT Creating USER modules views.;


PROMPT - Creating USER views.;
PROMPT   - vw_allusers;
CREATE OR REPLACE VIEW fv_user.vw_allusers
AS
SELECT usr.UserId, usr.FirstName, usr.LastName, usr.Dni,
       pro.ProfileId, pro.ProfileName,
       cre.CredentialId, cre.Username, cre.Password, cre.Email, cre.IsActive,
       CASE cre.IsActive
           WHEN 1 THEN 'Activo'
                  ELSE 'Inactivo'
       END AS UserStatus
FROM fv_user.user_registration   usr
    JOIN fv_user.user_credential cre ON usr.UserId = cre.UserId
    JOIN fv_user.user_profile    pro ON usr.ProfileId = pro.ProfileId
ORDER BY usr.LastName, usr.FirstName;
/


PROMPT   - vw_users;
CREATE OR REPLACE VIEW fv_user.vw_users
AS
SELECT usr.UserId, usr.FirstName, usr.LastName, usr.Dni,
       pro.ProfileId, pro.ProfileName,
       cre.CredentialId, cre.Username, cre.Password, cre.Email, cre.IsActive,
       CASE cre.IsActive
           WHEN 1 THEN 'Activo'
                  ELSE 'Inactivo'
       END AS UserStatus
FROM fv_user.user_registration   usr
    JOIN fv_user.user_credential cre ON usr.UserId = cre.UserId
    JOIN fv_user.user_profile    pro ON usr.ProfileId = pro.ProfileId
WHERE usr.ProfileId > 2
ORDER BY usr.LastName, usr.FirstName;
/


PROMPT   - vw_employeess;
CREATE OR REPLACE VIEW fv_user.vw_employees
AS
SELECT usr.UserId, usr.FirstName, usr.LastName,
       usr.FirstName || ' ' || usr.LastName AS FullName, usr.Dni,
       pro.ProfileId, pro.ProfileName,
       cre.CredentialId, cre.Username, cre.Password, cre.Email, cre.IsActive,
       CASE cre.IsActive
           WHEN 1 THEN 'Activo'
                  ELSE 'Inactivo'
       END AS UserStatus
FROM fv_user.user_registration   usr
    JOIN fv_user.user_credential cre ON usr.UserId = cre.UserId
    JOIN fv_user.user_profile    pro ON usr.ProfileId = pro.ProfileId
WHERE usr.ProfileId < 3
ORDER BY usr.LastName, usr.FirstName;
/


PROMPT USER modules views was created.;
PROMPT;
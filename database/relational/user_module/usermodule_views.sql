-- File name    : usermodule_views.sql
-- Description  : Create user module views for feria virtual.
-- Author       : Daniel García Asathor


SET ECHO OFF;
SET feedback OFF;
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
ALTER SESSION SET NLS_LANGUAGE= 'SPANISH' NLS_TERRITORY= 'Spain' NLS_CURRENCY= '$' NLS_ISO_CURRENCY= 'AMERICA' NLS_NUMERIC_CHARACTERS= '.,' NLS_CALENDAR= 'GREGORIAN' NLS_DATE_FORMAT= 'DD-MON-RR' NLS_DATE_LANGUAGE= 'SPANISH' NLS_SORT= 'BINARY';
prompt Creating user modules views.;


prompt - Creating user views.;
prompt   - vw_allusers;
CREATE OR REPLACE VIEW fv_user.vw_allusers
AS
SELECT usr.UserId, usr.FirstName, usr.LastName, usr.Dni,
       pro.ProfileId, pro.ProfileName,
       cre.CredentialId, cre.Username, cre.Password, cre.Email, cre.IsActive,
       CASE cre.IsActive
           WHEN 1 THEN 'Activo'
           ELSE 'Inactivo'
           END AS UserStatus
FROM fv_user.user_registration        usr
         JOIN fv_user.user_credential cre ON usr.CredentialId = cre.CredentialId
         JOIN fv_user.user_profile    pro ON usr.ProfileId = pro.ProfileId
ORDER BY usr.LastName, usr.FirstName;
/





prompt   - vw_users;
CREATE OR REPLACE VIEW fv_user.vw_users
AS
SELECT usr.UserId, usr.FirstName, usr.LastName, usr.Dni,
       pro.ProfileId, pro.ProfileName,
       cre.CredentialId, cre.Username, cre.Password, cre.Email, cre.IsActive,
       CASE cre.IsActive
           WHEN 1 THEN 'Activo'
           ELSE 'Inactivo'
           END AS UserStatus
FROM fv_user.user_registration        usr
         JOIN fv_user.user_credential cre ON usr.CredentialId = cre.CredentialId
         JOIN fv_user.user_profile    pro ON usr.ProfileId = pro.ProfileId
WHERE usr.ProfileId > 2
ORDER BY usr.LastName, usr.FirstName;
/


prompt   - vw_employeess;
CREATE OR REPLACE VIEW fv_user.vw_employees
AS
SELECT usr.UserId, usr.FirstName, usr.LastName, usr.Dni,
       pro.ProfileId, pro.ProfileName,
       cre.CredentialId, cre.Username, cre.Password, cre.Email, cre.IsActive,
       CASE cre.IsActive
           WHEN 1 THEN 'Activo'
           ELSE 'Inactivo'
           END AS UserStatus
FROM fv_user.user_registration        usr
         JOIN fv_user.user_credential cre ON usr.CredentialId = cre.CredentialId
         JOIN fv_user.user_profile    pro ON usr.ProfileId = pro.ProfileId
WHERE usr.ProfileId < 3
ORDER BY usr.LastName, usr.FirstName;
/


prompt User modules views was created.;
prompt;
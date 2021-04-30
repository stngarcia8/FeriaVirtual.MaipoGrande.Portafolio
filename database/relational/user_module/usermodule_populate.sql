-- File name    : usermodule_populate.sql
-- Description  : Populate user module tables.
-- Author       : Daniel García Asathor


SET ECHO OFF;
SET FEEDBACK OFF;
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
ALTER SESSION SET NLS_LANGUAGE= 'SPANISH' NLS_TERRITORY= 'Spain' NLS_CURRENCY= '$' NLS_ISO_CURRENCY= 'AMERICA' NLS_NUMERIC_CHARACTERS= '.,' NLS_CALENDAR= 'GREGORIAN' NLS_DATE_FORMAT= 'DD-MON-RR' NLS_DATE_LANGUAGE= 'SPANISH' NLS_SORT= 'BINARY';
PROMPT Starting TO populate USER module TABLES FOR INITIAL execution.;


PROMPT - INSERTING USER profiles.;
INSERT INTO fv_user.user_profile (ProfileId, ProfileName)
VALUES (1, 'Administrador');
INSERT INTO fv_user.user_profile (ProfileId, ProfileName)
VALUES (2, 'Consultor');
INSERT INTO fv_user.user_profile (ProfileId, ProfileName)
VALUES (3, 'Cliente externo');
INSERT INTO fv_user.user_profile (ProfileId, ProfileName)
VALUES (4, 'Cliente interno');
INSERT INTO fv_user.user_profile (ProfileId, ProfileName)
VALUES (5, 'Productor');
INSERT INTO fv_user.user_profile (ProfileId, ProfileName)
VALUES (6, 'Transportista');


PROMPT INSERTING example administrator USER.;
INSERT INTO fv_user.user_registration (UserId, ProfileId, FirstName, LastName, Dni)
VALUES ('542818c0-089b-d842-0edc-00f000200057',
        1,
        'Daniel',
        'Garcia Asathor',
        '12345678-K');


PROMPT INSERTING example USERS  FOR TEST.;
INSERT INTO fv_user.user_registration (UserId, ProfileId, FirstName, LastName, Dni)
VALUES ('aa3ed254-ff6d-4c3c-97b6-048efdedaf69',
        '3',
        'Daniela',
        'Garcia Roman',
        '12345678-1');
INSERT INTO fv_user.user_registration (UserId, ProfileId, FirstName, LastName, Dni)
VALUES ('729d6773-a60c-4dd5-9e39-9629e44c98b2',
        '4',
        'Loreto',
        'Roman Quiroz',
        '12345678-2');
INSERT INTO fv_user.user_registration (UserId, ProfileId, FirstName, LastName, Dni)
VALUES ('08daae9c-d977-4234-a054-0b83918ed3e7',
        '5',
        'Flo',
        'Garcia Roman',
        '12345678-3');
INSERT INTO fv_user.user_registration (UserId, ProfileId, FirstName, LastName, Dni)
VALUES ('5f950227-a59a-48ec-a358-a403ede00bca',
        '6',
        'lolita',
        'Garcia Roman',
        '12345678-4');
INSERT INTO fv_user.user_registration (UserId, ProfileId, FirstName, LastName, Dni)
VALUES ('ac9ce2f8-08e0-d8ab-d8dd-00b100bc0019',
        2,
        'User',
        'For Test',
        '09876543-0');


PROMPT - INSERTING SAMPLE credentials FOR TEST USERS.;
INSERT INTO fv_user.user_credential (CredentialId, UserId, Username, Password, Email, IsActive)
VALUES ('44a1064e-0862-d8cd-87dc-00f000200060',
        '542818c0-089b-d842-0edc-00f000200057',
        'd.garcial',
        '9cf9951f2bb3fedc9f709c7314fb9fb672c7a66e',
        'd.garcial@alumnos.duoc.cl',
        1);
INSERT INTO fv_user.user_credential (CredentialId, UserId, Username, Password, Email, IsActive)
VALUES ('d124fdef-6956-460f-9873-1953fe29f81b',
        '5f950227-a59a-48ec-a358-a403ede00bca',
        'l.garciar',
        '552668dcde69cd6c10aebb8e5ee4e61dfb54050a',
        'stngarcia8@gmail.com',
        1);
INSERT INTO fv_user.user_credential (CredentialId, UserId, Username, Password, Email, IsActive)
VALUES ('a3220c48-ddb2-4fe8-8e80-8bc832fb80d5',
        '08daae9c-d977-4234-a054-0b83918ed3e7',
        'f.garciar',
        '92d52f9c820e4e291318819f2ab5514dd8a389ea',
        'stngarcia8@gmail.com',
        1);
INSERT INTO fv_user.user_credential (CredentialId, UserId, Username, Password, Email, IsActive)
VALUES ('d78ee803-2e99-4c87-a684-d600e6540564',
        'aa3ed254-ff6d-4c3c-97b6-048efdedaf69',
       'd.garciar',
        '6f57196fd9309e992379d3c90fec691531219eea',
        'stngarcia8@gmail.com',
        1);
INSERT INTO fv_user.user_credential (CredentialId, UserId, Username, Password, Email, IsActive)
VALUES ('e7d1d546-84ad-4420-bb05-169aebc376a5',
        '729d6773-a60c-4dd5-9e39-9629e44c98b2',
        'l.romanq',
        '7a4013826e6cbb73d29cbea95ce32abcba60aa6e',
        'stngarcia8@gmail.com',
        1);
INSERT INTO fv_user.user_credential (CredentialId, UserId, Username, Password, Email, IsActive)
VALUES ('94155b73-0866-d8aa-77dd-00b100bc0022',
        'ac9ce2f8-08e0-d8ab-d8dd-00b100bc0019',
        'user.test',
        'a55d3ef664c94df0c32f44bc299d3e4180df61e8',
        'user.test@domain.com',
        0);


PROMPT - Commiting changes.;
COMMIT;


PROMPT Populate USER module TABLES was finished.;
PROMPT;



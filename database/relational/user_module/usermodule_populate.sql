-- File name    : usermodule_populate.sql
-- Description  : Populate user module tables.
-- Author       : Daniel García Asathor


SET ECHO OFF;
set feedback off;
ALTER SESSION SET "_ORACLE_SCRIPT" = true;
ALTER SESSION SET NLS_LANGUAGE= 'SPANISH' NLS_TERRITORY= 'Spain' NLS_CURRENCY= '$' NLS_ISO_CURRENCY= 'AMERICA' NLS_NUMERIC_CHARACTERS= '.,' NLS_CALENDAR= 'GREGORIAN' NLS_DATE_FORMAT= 'DD-MON-RR' NLS_DATE_LANGUAGE= 'SPANISH' NLS_SORT= 'BINARY';
prompt Starting to populate user module tables for initial execution.;


prompt - Inserting user profiles.;
insert into fv_user.user_profile (ProfileId, ProfileName)
values (1, '"Administrador');
insert into fv_user.user_profile (ProfileId, ProfileName)
values (2, '"Consultor');
insert into fv_user.user_profile (ProfileId, ProfileName)
values (3, '"Cliente externo');
insert into fv_user.user_profile (ProfileId, ProfileName)
values (4, '"Cliente interno');
insert into fv_user.user_profile (ProfileId, ProfileName)
values (5, '"Productor');
insert into fv_user.user_profile (ProfileId, ProfileName)
values (6, '"Transportista');


prompt - Inserting sample credentials for test users.;
insert into fv_user.user_credential (CredentialId, Username, Password, Email, IsActive)
VALUES ('44a1064e-0862-d8cd-87dc-00f000200060', 'd.garcial', '9cf9951f2bb3fedc9f709c7314fb9fb672c7a66e',
        'd.garcial@alumnos.duoc.cl', 1);
insert into fv_user.user_credential (CredentialId, Username, Password, Email, IsActive)
values ('d124fdef-6956-460f-9873-1953fe29f81b', 'l.garciar', '552668dcde69cd6c10aebb8e5ee4e61dfb54050a',
        'stngarcia8@gmail.com', 1);
insert into fv_user.user_credential (CredentialId, Username, Password, Email, IsActive)
values ('a3220c48-ddb2-4fe8-8e80-8bc832fb80d5', 'f.garciar', '92d52f9c820e4e291318819f2ab5514dd8a389ea',
        'stngarcia8@gmail.com', 1);
insert into fv_user.user_credential (CredentialId, Username, Password, Email, IsActive)
values ('d78ee803-2e99-4c87-a684-d600e6540564', 'd.garciar', '6f57196fd9309e992379d3c90fec691531219eea',
        'stngarcia8@gmail.com', 1);
insert into fv_user.user_credential (CredentialId, Username, Password, Email, IsActive)
values ('e7d1d546-84ad-4420-bb05-169aebc376a5', 'l.romanq', '7a4013826e6cbb73d29cbea95ce32abcba60aa6e',
        'stngarcia8@gmail.com', 1);
insert into fv_user.user_credential (CredentialId, Username, Password, Email, IsActive)
values ('94155b73-0866-d8aa-77dd-00b100bc0022', 'user.test', 'a55d3ef664c94df0c32f44bc299d3e4180df61e8',
        'user.test@domain.com', 1);


prompt Inserting example administrator user.;
INSERT INTO fv_user.user_registration (UserId, CredentialId, ProfileId, FirstName, LastName, Dni)
VALUES ('542818c0-089b-d842-0edc-00f000200057', '44a1064e-0862-d8cd-87dc-00f000200060', 1, 'Daniel', 'Garcia Asathor',
        '12345678-K');


prompt Inserting example users  for test.;
insert into fv_user.user_registration (UserId, CredentialId, ProfileId, FirstName, LastName, Dni)
values ('aa3ed254-ff6d-4c3c-97b6-048efdedaf69', 'd78ee803-2e99-4c87-a684-d600e6540564', '3', 'Daniela', 'Garcia Roman',
        '12345678-1');
insert into fv_user.user_registration (UserId, CredentialId, ProfileId, FirstName, LastName, Dni)
values ('729d6773-a60c-4dd5-9e39-9629e44c98b2', 'e7d1d546-84ad-4420-bb05-169aebc376a5', '4', 'Loreto', 'Roman Quiroz',
        '12345678-2');
insert into fv_user.user_registration (UserId, CredentialId, ProfileId, FirstName, LastName, Dni)
values ('08daae9c-d977-4234-a054-0b83918ed3e7', 'a3220c48-ddb2-4fe8-8e80-8bc832fb80d5', '5', 'Flo', 'Garcia Roman',
        '12345678-3');
insert into fv_user.user_registration (UserId, CredentialId, ProfileId, FirstName, LastName, Dni)
values ('5f950227-a59a-48ec-a358-a403ede00bca', 'd124fdef-6956-460f-9873-1953fe29f81b', '6', 'lolita', 'Garcia Roman',
        '12345678-4');
INSERT INTO fv_user.user_registration (UserId, CredentialId, ProfileId, FirstName, LastName, Dni)
VALUES ('ac9ce2f8-08e0-d8ab-d8dd-00b100bc0019', '94155b73-0866-d8aa-77dd-00b100bc0022', 2, 'User', 'For Test',
        '09876543-0');

prompt - Commiting changes.;
commit;


prompt Populate user module tables was finished.;
prompt;



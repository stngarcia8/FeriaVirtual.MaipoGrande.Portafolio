-- File name    : EventStore_ObjectsScript.sql
-- Description  : Create table for FeriaVirtual events.
-- Author       : Daniel García Asathor


SET ECHO OFF;
set feedback off;
ALTER SESSION SET "_ORACLE_SCRIPT" = true;
ALTER SESSION SET NLS_LANGUAGE= 'SPANISH' NLS_TERRITORY= 'Spain' NLS_CURRENCY= '$' NLS_ISO_CURRENCY= 'AMERICA' NLS_NUMERIC_CHARACTERS= '.,' NLS_CALENDAR= 'GREGORIAN' NLS_DATE_FORMAT= 'DD-MON-RR' NLS_DATE_LANGUAGE= 'SPANISH' NLS_SORT= 'BINARY';

prompt;
prompt Creating event store objects.;

prompt - Creating event store  table.;
CREATE TABLE fv_eventuser.event_store
(
    EventId     VARCHAR2(36)   NOT NULL,
    AggregateId varchar2(36)   not null,
    name        varchar2(255)  not null,
    body        varchar2(4000) not null,
    OcurredOn   date default sysdate,
    constraint Event_pk primary key (EventId)
) tablespace fv_env;


prompt - Creating event stored procedure.;
create or replace procedure fv_eventuser.sp_add_event(
    pEventId varchar2,
    pAggregateId varchar2,
    pName varchar2,
    pBody varchar2,
    pOcurredOn date
) is
begin
insert into fv_eventuser.event_store
(EventId, AggregateId, Name, Body, OcurredOn)
values (pEventId, pAggregateId, pName, pBody, pOcurredOn);
end sp_add_event;
/


prompt Event store objects was created.;
prompt;


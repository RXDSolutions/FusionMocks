CREATE TABLE RISK_USER_PROFILES
(	
   "USER_IDENT" NUMBER(10,0) NOT NULL ENABLE, 
   "PROFILE_IDENT" NUMBER(10,0) NOT NULL ENABLE
);

CREATE TABLE RISKUSERS 
(	
   "IDENT" NUMBER(10,0) NOT NULL ENABLE, 
   "NAME" VARCHAR2(40 BYTE), 
   "PASSWORD" VARCHAR2(40 BYTE)
);

CREATE TABLE USER_RIGHT_TABLE 
(	
   "NAME" VARCHAR2(50 BYTE) NOT NULL ENABLE, 
   "CATEGORY" VARCHAR2(50 BYTE) NOT NULL ENABLE, 
   "INTERNAL_RIGHT" NUMBER(10,0), 
   "RIGHT_TYPE" NUMBER(10,0), 
   "RIGHT" NUMBER(10,0), 
   "IDX" NUMBER(10,0) NOT NULL ENABLE, 
   "COMMENTS" VARCHAR2(100 BYTE)
);

create or replace function       getuserid return number as 
begin
  return 1;
end getuserid;

create or replace function STR_TO_NUM(str2 char)
return number is str char(8);
begin
    str:=rpad(str2,4,chr(0));
    return ascii(substr(str,4,1))+256*(ascii(substr(str,3,1)) + 256*(ascii(substr(str,2,1)) + 256*ascii(substr(str,1,1))));
end;
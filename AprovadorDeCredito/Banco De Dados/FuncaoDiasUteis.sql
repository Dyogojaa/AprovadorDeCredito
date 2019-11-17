create or replace FUNCTION DIAS_UTEIS( vDATA1 IN DATE, vDATA2 IN DATE) RETURN NUMBER IS
  vtemp  number;
begin
  select count(dat)into vtemp
  from (select vdata1 + rownum-1 dat from all_tables where rownum <= ( vdata2-vdata1)+1 )
  where to_char(dat, 'd') not in (1,7);
  RETURN vtemp;
end;

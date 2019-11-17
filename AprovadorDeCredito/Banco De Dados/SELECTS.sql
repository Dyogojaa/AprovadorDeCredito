
--Listar todos os clientes do estado de SP que tenham mais de 60% das parcelas pagas.
SELECT cli.nome, cli.uf FROM PARCELA par 
join FINANCIAMENTO fin on par.idfinanciamento = fin.idfinanciamento
join cliente cli on fin.idfinanciamento = cli.idfinanciamento
where cli.uf ='SP' and  (fin.valortotal *0.6) >= (select sum(par.valor) from parcela where parcela.idparcela =par.idparcela)

--Listar os primeiros 4 clientes que tenham alguma parcela com mais de 05 dias atrasadas
--(Data Vencimento maior que data atual E data pagamento nula)
SELECT cli.nome, cli.uf FROM PARCELA par 
join FINANCIAMENTO fin on par.idfinanciamento = fin.idfinanciamento
join cliente cli on fin.idfinanciamento = cli.idfinanciamento
where dias_uteis( par.datavencimento, sysdate) >5 and ROWNUM = 4

--Listar todos os clientes que já atrasaram em algum momento duas ou mais parcelas em
--mais de 10 dias, e que o valor do financiamento seja maior que R$ 10.000,00.
SELECT cli.nome, cli.uf FROM PARCELA par 
join FINANCIAMENTO fin on par.idfinanciamento = fin.idfinanciamento
join cliente cli on fin.idfinanciamento = cli.idfinanciamento
where dias_uteis( par.datavencimento, par.datapagamento) >10 and fin.valortotal > 10000




 


CREATE TABLE PARCELA(
  idParcela Number(10)  NOT NULL,
  idFinanciamento Number(10) NOT NULL,
  Parcela Number(10) NOT NULL,
  Valor Number(18, 2) NOT NULL,
  DataVencimento date NOT NULL,
  DataPagamento date NULL,
 CONSTRAINT PK_PARCELA PRIMARY KEY 
(
  idParcela 
) 
);


-- Generate ID using sequence and trigger
CREATE SEQUENCE PARCELA_seq START WITH 1 INCREMENT BY 1;

CREATE OR REPLACE TRIGGER PARCELA_seq_tr
 BEFORE INSERT ON PARCELA FOR EACH ROW
 WHEN (NEW.idParcela IS NULL)
BEGIN
 SELECT PARCELA_seq.NEXTVAL INTO :NEW.idParcela FROM DUAL;
END;

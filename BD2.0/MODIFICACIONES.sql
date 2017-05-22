USE reservación_vuelos;
GO

SELECT * FROM vuelo;
SELECT * FROM ciudad;
SELECT * FROM cliente;
SELECT * FROM club_premier;
SELECT * FROM boleto; 
SELECT * FROM descuento;

-- Remove numPasajeros because it's duplicated :c
ALTER TABLE vuelo
DROP COLUMN numPasajeros;

-- 'UPPER' everything, because Katy's it's gonna kill me if I don't :c
UPDATE días SET díaVuelo = UPPER(díaVuelo);
UPDATE ciudad SET nombreCiudad = UPPER(nombreCiudad), estado = UPPER(estado);
UPDATE cliente SET nombre = UPPER(nombre);
UPDATE club_premier SET domicilio = UPPER(domicilio);

-- Add millasAcumuladas to Club Premier c:
ALTER TABLE club_premier
ADD millasAcumuladas DECIMAL(10,3) NOT NULL 
CONSTRAINT m DEFAULT 0;

SELECT DISTINCT cveCliente FROM boleto;

-- Millas acumuladas de los clientes de club_premier
SELECT b.cveCliente, SUM(millas) FROM boleto b INNER JOIN club_premier cp ON b.cveCliente = cp.cveClubPremier 
INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo GROUP BY b.cveCliente;

SELECT * FROM club_premier;

CREATE PROC AcumularMillas
AS 
BEGIN
	DECLARE millasAcum CURSOR FOR
		SELECT b.cveCliente AS cliente, SUM(millas) AS m FROM boleto b INNER JOIN club_premier cp ON b.cveCliente = cp.cveCliente
		INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo GROUP BY b.cveCliente;

OPEN millasAcum;
DECLARE @c1 INT, @m1 DECIMAL;


FETCH NEXT FROM millasAcum INTO @c1, @m1
WHILE @@FETCH_STATUS = 0
	BEGIN
		FETCH NEXT FROM millasAcum INTO @c1, @m1
		IF @c1 IN (SELECT cveCliente FROM club_premier)
				PRINT 'Cliente: '+ CAST(@c1 as char(8)) + ' Millas: ' + CAST(@m1 as char(8))
				UPDATE club_premier SET millasAcumuladas = @m1 WHERE cveCliente = @c1;
	END
	CLOSE millasAcum
	DEALLOCATE millasAcum
END

EXEC AcumularMillas;
--DROP PROC AcumularMillas;

SELECT DISTINCT cveCliente FROM boleto WHERE cveCliente IN (SELECT cveCliente FROM club_premier);

SELECT DISTINCT b.cveCliente FROM boleto b INNER JOIN club_premier cp ON b.cveCliente = cp.cveCliente;
SELECT * FROM club_premier WHERE millasAcumuladas > 0 ORDER BY cveCliente;

-- No sé por qué no funcionó con el 4 :c
UPDATE club_premier SET millasAcumuladas = 559.960 WHERE cveCliente = 4;


-- Change datatype of claveBoleto
ALTER TABLE boleto
	DROP CONSTRAINT PK__boleto__905F43C0C0ADB472;


ALTER TABLE boleto
	ADD claveBoleto CHAR(15)

ALTER TABLE boleto
	DROP COLUMN claveBoleto

ALTER TABLE boleto
	ADD claveBoleto VARCHAR(15)

-- Llenar con datos
CREATE PROC clavesboletos
AS 
BEGIN
	DECLARE cve CURSOR FOR
		SELECT claveBoleto AS c FROM boleto;
OPEN cve;
DECLARE @cont INT, @c INT, @clave VARCHAR;
FETCH NEXT FROM cve INTO @c;
SET @cont = 1;
WHILE @@FETCH_STATUS = 0
	BEGIN
		FETCH NEXT FROM cve INTO @c
			PRINT 'Clave: '+ CAST(@cont as char(8)) + 'Contador: '+ CAST(@cont as char(8))
			UPDATE boleto SET claveBoleto = CAST(@cont as char(8))  WHERE cveBoleto = @cont;
			SET @cont = @cont + 1;
	END
	CLOSE cve
	DEALLOCATE cve
END

EXEC clavesboletos;
-- DROP PROC clavesBoletos;

-- UPDATE CLAVE BOLETO
UPDATE boleto SET claveBoleto = 'V9LITWEOVVZ7HRZ' 
  WHERE claveBoleto = '1'

UPDATE boleto SET claveBoleto = '824X7MNTXCCR4MS' 
  WHERE claveBoleto = '2'

UPDATE boleto SET claveBoleto = 'E10X3UTS8TDM5PY' 
  WHERE claveBoleto = '3'

UPDATE boleto SET claveBoleto = 'QHOTMGMHE8IPXFQ' 
  WHERE claveBoleto = '4'

UPDATE boleto SET claveBoleto = 'FJCDQ8GTXEOK6E3' 
  WHERE claveBoleto = '5'

UPDATE boleto SET claveBoleto = 'ARE9V5CL9L2TWZV' 
  WHERE claveBoleto = '6'

UPDATE boleto SET claveBoleto = 'E5MRO3J180KX0O7' 
  WHERE claveBoleto = '7'

UPDATE boleto SET claveBoleto = '5QDK80LYUUC7C2Y' 
  WHERE claveBoleto = '8'

UPDATE boleto SET claveBoleto = 'OU4CAT8PZ900FJL' 
  WHERE claveBoleto = '9'

UPDATE boleto SET claveBoleto = 'HL7CPLQL042H16L' 
  WHERE claveBoleto = '10'

UPDATE boleto SET claveBoleto = '6G9KLZ3YNN7BNKH' 
  WHERE claveBoleto = '11'

UPDATE boleto SET claveBoleto = 'AGOIN0AAMM8JDHH' 
  WHERE claveBoleto = '12'

UPDATE boleto SET claveBoleto = 'MGSODT057VOXTYS' 
  WHERE claveBoleto = '13'

UPDATE boleto SET claveBoleto = 'KDAT3W2TTU6GW7N' 
  WHERE claveBoleto = '14'

UPDATE boleto SET claveBoleto = 'QZQGB1S9HYKLQW8' 
  WHERE claveBoleto = '15'

UPDATE boleto SET claveBoleto = 'DQM4C5JUOVUX93H' 
  WHERE claveBoleto = '16'

UPDATE boleto SET claveBoleto = 'ND7UFYGNX01D24T' 
  WHERE claveBoleto = '17'

UPDATE boleto SET claveBoleto = 'KL6URP325SHFCUR' 
  WHERE claveBoleto = '18'

UPDATE boleto SET claveBoleto = 'ETGAKGN6RK7DZDK' 
  WHERE claveBoleto = '19'

UPDATE boleto SET claveBoleto = '1QZ4LI1OL1TLCC8' 
  WHERE claveBoleto = '20'

UPDATE boleto SET claveBoleto = 'TE3FWI72UN6POKU' 
  WHERE claveBoleto = '21'

UPDATE boleto SET claveBoleto = 'MEYU00PHJINE4I1' 
  WHERE claveBoleto = '22'

UPDATE boleto SET claveBoleto = '4L3S02JTRC3XFQO' 
  WHERE claveBoleto = '23'

UPDATE boleto SET claveBoleto = '3ME1POXRLHD6T7J' 
  WHERE claveBoleto = '24'

UPDATE boleto SET claveBoleto = 'DDU3TVV6T1CVHS7' 
  WHERE claveBoleto = '25'

UPDATE boleto SET claveBoleto = 'DK04PAAC2MH3RLX' 
  WHERE claveBoleto = '26'

UPDATE boleto SET claveBoleto = '60WH80DM72HQUAN' 
  WHERE claveBoleto = '27'

UPDATE boleto SET claveBoleto = '3P9OE3FYRIDA1QL' 
  WHERE claveBoleto = '28'

UPDATE boleto SET claveBoleto = '1EU65M9ATGA83CI' 
  WHERE claveBoleto = '29'

UPDATE boleto SET claveBoleto = 'UPCPT14DH30BE85' 
  WHERE claveBoleto = '30'

UPDATE boleto SET claveBoleto = 'ZL5VBD5YFA3PPHE' 
  WHERE claveBoleto = '31'

UPDATE boleto SET claveBoleto = '5MWJXX8L7T7BNCE' 
  WHERE claveBoleto = '32'

UPDATE boleto SET claveBoleto = 'L5BYRYCHAFZ16OZ' 
  WHERE claveBoleto = '33'

UPDATE boleto SET claveBoleto = 'MP5C8OO4KI198CD' 
  WHERE claveBoleto = '34'

UPDATE boleto SET claveBoleto = 'CRVAZ8N10P2EVE8' 
  WHERE claveBoleto = '35'

UPDATE boleto SET claveBoleto = '5B7IHSFKD06A1PZ' 
  WHERE claveBoleto = '36'

UPDATE boleto SET claveBoleto = 'YEF7CIG6Y08XEWG' 
  WHERE claveBoleto = '37'

UPDATE boleto SET claveBoleto = 'J20MNZC04V6GRJ3' 
  WHERE claveBoleto = '38'

UPDATE boleto SET claveBoleto = '8WLA1Y9YBZYFIRI' 
  WHERE claveBoleto = '39'

UPDATE boleto SET claveBoleto = '4BX7RDKOCAVOKLG' 
  WHERE claveBoleto = '40'

UPDATE boleto SET claveBoleto = 'CYW52MMD5SJDYWY' 
  WHERE claveBoleto = '41'

UPDATE boleto SET claveBoleto = 'U4IW14SU2ZYIIAF' 
  WHERE claveBoleto = '42'

UPDATE boleto SET claveBoleto = 'JZN4XASMZ5S72PI' 
  WHERE claveBoleto = '43'

UPDATE boleto SET claveBoleto = 'AV1OQ1FXULTE4GD' 
  WHERE claveBoleto = '44'

UPDATE boleto SET claveBoleto = 'EDD0IU038XBRS0I' 
  WHERE claveBoleto = '45'

UPDATE boleto SET claveBoleto = '70FUZCQ4UNDB2TE' 
  WHERE claveBoleto = '46'

UPDATE boleto SET claveBoleto = '5YGV1P4BGYJ220O' 
  WHERE claveBoleto = '47'

UPDATE boleto SET claveBoleto = 'JW6LO39KRBXITME' 
  WHERE claveBoleto = '48'

UPDATE boleto SET claveBoleto = 'S7K42NL793DY86P' 
  WHERE claveBoleto = '49'

UPDATE boleto SET claveBoleto = 'KXDFEREQEK6OYTD' 
  WHERE claveBoleto = '50'

UPDATE boleto SET claveBoleto = 'GLZBFLR78B7Z7SL' 
  WHERE claveBoleto = '51'

UPDATE boleto SET claveBoleto = 'FAOB1AENIXNQFU5' 
  WHERE claveBoleto = '52'

UPDATE boleto SET claveBoleto = '9XN5X2960E2ZFEG' 
  WHERE claveBoleto = '53'

UPDATE boleto SET claveBoleto = '1H83F69X2DB7QO2' 
  WHERE claveBoleto = '54'

UPDATE boleto SET claveBoleto = '4LNDCKLC4TGDX79' 
  WHERE claveBoleto = '55'

UPDATE boleto SET claveBoleto = 'L9JC5GSMP899V2V' 
  WHERE claveBoleto = '56'

UPDATE boleto SET claveBoleto = '4SS8JQLCB5PEEJ8' 
  WHERE claveBoleto = '57'

UPDATE boleto SET claveBoleto = '2MZ32BXOSVM98ED' 
  WHERE claveBoleto = '58'

UPDATE boleto SET claveBoleto = 'K0KIYXVZXS97HGQ' 
  WHERE claveBoleto = '59'

UPDATE boleto SET claveBoleto = 'BNCQFXK29UHE9M7' 
  WHERE claveBoleto = '60'

UPDATE boleto SET claveBoleto = 'QN78UZ35VLHWBK2' 
  WHERE claveBoleto = '61'

UPDATE boleto SET claveBoleto = 'EPHCU87R8PA8KYR' 
  WHERE claveBoleto = '62'

UPDATE boleto SET claveBoleto = 'TVN0BV9JV0HSRF8' 
  WHERE claveBoleto = '63'

UPDATE boleto SET claveBoleto = 'AIRHP16728T58SU' 
  WHERE claveBoleto = '64'

UPDATE boleto SET claveBoleto = '1TGE1WILJGEGVLM' 
  WHERE claveBoleto = '65'

UPDATE boleto SET claveBoleto = 'PPMAP2RDJZWYV2R' 
  WHERE claveBoleto = '66'

UPDATE boleto SET claveBoleto = '0B0B9YMNNM26IAK' 
  WHERE claveBoleto = '67'

UPDATE boleto SET claveBoleto = 'VKVPSDT8D1JQ7OE' 
  WHERE claveBoleto = '68'

UPDATE boleto SET claveBoleto = '8WS1QDPUMXDC8YW' 
  WHERE claveBoleto = '69'

UPDATE boleto SET claveBoleto = '5IC9ELCFJNGDWJZ' 
  WHERE claveBoleto = '70'

UPDATE boleto SET claveBoleto = 'IP8JOFNQTGF0J1O' 
  WHERE claveBoleto = '71'

UPDATE boleto SET claveBoleto = 'BVJR6BN8K25QJNK' 
  WHERE claveBoleto = '72'

UPDATE boleto SET claveBoleto = 'A3KWPYEZKQR1T28' 
  WHERE claveBoleto = '73'

UPDATE boleto SET claveBoleto = 'V3O4MV3FNY4QYQS' 
  WHERE claveBoleto = '74'

UPDATE boleto SET claveBoleto = 'ZEDJFMPWM0659AO' 
  WHERE claveBoleto = '75'

UPDATE boleto SET claveBoleto = 'J4FLHBCOAYHX78U' 
  WHERE claveBoleto = '76'

UPDATE boleto SET claveBoleto = 'HPJ11NYJXWFHBEQ' 
  WHERE claveBoleto = '77'

UPDATE boleto SET claveBoleto = 'Z4F8PALNIQWZCU8' 
  WHERE claveBoleto = '78'

UPDATE boleto SET claveBoleto = 'YSX1SRWHIBUUSYB' 
  WHERE claveBoleto = '79'

UPDATE boleto SET claveBoleto = '4BKU9NS8TU6CAKF' 
  WHERE claveBoleto = '80'

UPDATE boleto SET claveBoleto = 'XVZY8XTJV8DW674' 
  WHERE claveBoleto = '81'

UPDATE boleto SET claveBoleto = 'Q3YHWVPSVVFTEHW' 
  WHERE claveBoleto = '82'

UPDATE boleto SET claveBoleto = 'OV6DO9530NK1YV5' 
  WHERE claveBoleto = '83'

UPDATE boleto SET claveBoleto = '0WAYDCN3YUIDDD3' 
  WHERE claveBoleto = '84'

UPDATE boleto SET claveBoleto = 'DPC9TRZ3T5U983L' 
  WHERE claveBoleto = '85'

UPDATE boleto SET claveBoleto = '306Z4SSPDTB2ISG' 
  WHERE claveBoleto = '86'

UPDATE boleto SET claveBoleto = '51Z6J5ZZBOA3R3T' 
  WHERE claveBoleto = '87'

UPDATE boleto SET claveBoleto = 'CO9M0RGNJKU98PS' 
  WHERE claveBoleto = '88'

UPDATE boleto SET claveBoleto = 'ZRKN92KBTQEB4L4' 
  WHERE claveBoleto = '89'

UPDATE boleto SET claveBoleto = 'ZBWUQW262YZNQWY' 
  WHERE claveBoleto = '90'


ALTER TABLE boleto
	DROP COLUMN cveBoleto

-- Me había faltado el 'no null' :c
ALTER TABLE boleto
	ALTER COLUMN claveBoleto VARCHAR(15) NOT NULL;

ALTER TABLE boleto
	ADD CONSTRAINT pk_cveboleto PRIMARY KEY(claveBoleto);

CREATE TABLE descuento (
	claveBoleto VARCHAR(15) PRIMARY KEY FOREIGN KEY REFERENCES boleto(claveBoleto),
	total DECIMAL(10,3) NOT NULL CHECK(total > 0)
)

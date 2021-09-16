# SQL PRACTICE

```<language>
SELECT TOP (1000) [Alias]
      ,[EmployeeId]
      ,[IsAdmin]
      ,[TrackId]
      ,[Specialty]
  FROM [M365BCCaseTrackDB].[dbo].[Engineer_Info]
  WHERE FirstName in ('yuan','anqi', 'tao')
```
in == mulitple choice?


## like keyword, pattern matching strings

```<language>
SELECT TOP (1000) [Alias]
      ,[EmployeeId]
      ,[Specialty]
  FROM [M365BCCaseTrackDB].[dbo].[Engineer_Info]
  WHERE Alias LIKE 'yu%'
```

```<language>

SELECT name FROM world
  WHERE name LIKE '%a%a%a%'
```
Find the countries that have **three or more a** in the name

```<language>
SELECT name FROM world
 WHERE name LIKE '%o__o%'
```
Find the countries that have two "o" characters separated by two others.


```<language>
SELECT name FROM world
WHERE name LIKE '%a%' AND 
name  LIKE '%e%' AND 
name  LIKE '%i%' AND 
name  LIKE '%o%' AND 
name  LIKE '%u%' AND 
name NOT LIKE '% %'
```
all vowels

## concat, replace

```<language>
SELECT name
  FROM world
 WHERE capital = concat(name,' City')

```
Find the country where the capital is the country plus "City".

```<language>

SELECT capital, name
  FROM world
 WHERE capital like concat('%', name, '%')

```
Find the capital and the name where the capital includes the name of the country.


```<language>
SELECT name, REPLACE(capital, name, '') as EXT 
FROM world 
WHERE capital LIKE concat('%', name, '%') AND capital > name;

```
For Monaco-Ville the name is Monaco and the extension is -Ville.
Show the name and the extension where the capital is an extension of name of the country.

## or, and, xor

```<language>
SELECT  name, population, area
FROM world
WHERE area > 3000000 xor population > 250000000 

```
Exclusive OR (XOR). Show the countries that are big by area (more than 3 million) or big by population (more than 250 million) but not both. 
Show name, population and area.

## rounding
```<language>

SELECT name, ROUND(population/1000000, 2), ROUND(gdp/1000000000, 2) 
FROM world 
WHERE continent = 'South America';
```
```<language>

SELECT name, round(gdp/population, -3) as 'per-capita GDP'
FROM world 
where gdp >= 1000000000000
```


## Trim: left, right
```<language>
SELECT name,  capital
FROM world
where LEFT(name,1) = LEFT(capital,1) and name != capital
```

Show the name and the capital where the first letters of each match. Don't include countries where the name and the capital are the same word.

## Escaping single quotes


You can't put a single quote in a quote string directly. You can use two single quotes within a quoted string.

```<language>
SELECT * FROM nobel
where winner ='Eugene O''Neill'

```

## order can be multiple

```<language>
SELECT winner, yr, subject
FROM nobel
WHERE winner LIKE 'sir%'
ORDER BY yr DESC, winner
```

## subject IN () can be bool

```<language>
SELECT winner, subject
FROM nobel
WHERE yr=1984
ORDER BY subject IN ('Physics','Chemistry'),subject,winner
```

## SELECT within SELECT Tutorial

SELECT name FROM world
  WHERE population >
     (SELECT population FROM world
      WHERE name='Russia')

List each country name where the population is larger than that of 'Russia'.

select name
from world
where (GDP/population) > (select (GDP/population) as 'per capita GDP' from world where name = 'United Kingdom') 
and continent = 'Europe'
Show the countries in Europe with a per capita GDP greater than 'United Kingdom'.



select name, continent
from world
where continent in (select continent from world where name in ('Argentina', 'Australia'))
order by name 

List the name and continent of countries in the continents containing either Argentina or Australia. Order by name of the country.

select name, concat(ROUND((population /(select population from world where name = 'Germany ')) * 100), '%') as Percentage 
from world
where continent = 'Europe'




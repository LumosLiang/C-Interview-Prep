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
in == mulitple choice, like a multiple choice


## like keyword, pattern matching strings

```<language>
SELECT TOP (1000) [Alias]
      ,[EmployeeId]
      ,[Specialty]
  FROM [M365BCCaseTrackDB].[dbo].[Engineer_Info]
  WHERE Alias LIKE 'yu%'
```

% placeholder in the back
like * in the powershell?

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

往下round
```<language>

SELECT name, round(gdp/population, -3) as 'per-capita GDP'
FROM world 
where gdp >= 1000000000000
```
往上round

## Trim: left, right
```<language>
SELECT name,  capital
FROM world
where LEFT(name,1) = LEFT(capital,1) and name != capital
```

Show the name and the capital where the first letters of each match. Don't include countries where the name and the capital are the same word.

## Escaping single quotes

```<language>
SELECT * FROM nobel
where winner ='Eugene O''Neill'
```
You can't put a single quote in a quote string directly. You can use two single quotes within a quoted string.

## order can be multiple

```<language>
SELECT winner, yr, subject
FROM nobel
WHERE winner LIKE 'sir%'
ORDER BY yr DESC, winner
```

It orders by yr, but if some rows have the same yr, it orders them by winner.

## subject IN () can be bool

```<language>
SELECT winner, subject
FROM nobel
WHERE yr=1984
ORDER BY subject IN ('Physics','Chemistry'),subject,winner
```

## SELECT within SELECT Tutorial

```<language>
SELECT name FROM world
  WHERE population >
     (SELECT population FROM world
      WHERE name='Russia')
```

List each country name where the population is larger than that of 'Russia'.

```<language>
select name
from world
where (GDP/population) > (select (GDP/population) as 'per capita GDP' from world where name = 'United Kingdom') 
and continent = 'Europe'
```

Show the countries in Europe with a per capita GDP greater than 'United Kingdom'.


```<language>
select name, continent
from world
where continent in (select continent from world where name in ('Argentina', 'Australia'))
order by name 
```

List the name and continent of countries in the continents containing either Argentina or Australia. Order by name of the country.

```<language>
select name, concat(ROUND((population /(select population from world where name = 'Germany ')) * 100), '%') as Percentage 
from world
where continent = 'Europe'
```
Show the name and the population of each country in Europe. Show the population as a percentage of the population of Germany.

## All, Any

```<language>
SELECT name
FROM world
WHERE GDP > ALL(SELECT GDP FROM world WHERE continent = 'Europe' and GDP>0)
```

Which countries have a GDP greater than every country in Europe? [Give the name only.] (Some countries may have NULL gdp values)

## outer select and inner select naming

We can refer to values in the outer SELECT within the inner SELECT. We can name the tables so that we can tell the difference between the inner and outer versions.

```<language>
SELECT continent, name, area FROM world x
  WHERE area >= ALL
    (SELECT area FROM world y
        WHERE y.continent=x.continent
          AND area >0)
```

Find the largest country (by area) in each continent, show the continent, the name and the area:

A correlated subquery works like a nested loop: the subquery only has access to rows related to a single record at a time in the outer query. The technique relies on table aliases to identify two different uses of the same table, one in the outer query and the other in the subquery.

One way to interpret the line in the WHERE clause that references the two table is “… where the correlated values are the same”.

In the example provided, you would say “select the country details from world where the population is greater than or equal to the population of all countries where the continent is the same”.

Another example:

```<language>
select continent, name from world x
where name <= ALL(SELECT name FROM world y WHERE y.continent = x.continent)
```

List each continent and the name of the country that comes first alphabetically.

```<language>
select  name, continent, population from world x
where 25000000 >= ALL(SELECT population FROM world y WHERE y.continent = x.continent)
```

Find the continents where all countries have a population <= 25000000. Then find the names of the countries associated with these continents. Show name, continent and population.

```<language>
select name, continent from world x
where population / 3 >= ALL(
SELECT population FROM world y WHERE y.continent = x.continent and y.name != x.name
)

```
Some countries have populations more than three times that of any of their neighbours (in the same continent). Give the countries and continents.


## Sum 

```<language>
SELECT SUM(population)
FROM world
```

Show the total population of the world.

SELECT SUM(GDP)
FROM world
where continent = 'Africa'

Give the total GDP of Africa

SELECT sum(population)
FROM world
where name in  ('Estonia', 'Latvia', 'Lithuania')

What is the total population of ('Estonia', 'Latvia', 'Lithuania')



## DISTINCT 

SELECT DISTINCT(continent)
FROM world

List all the continents - just once each.

## Count

SELECT COUNT(name)
FROM world
where area >= 1000000

## GROUP BY and HAVING

By including a GROUP BY clause functions such as SUM and COUNT are applied to groups of items sharing values. When you specify GROUP BY continent the result is that you get only one row for each different value of continent. All the other columns must be "aggregated" by one of SUM, COUNT ...

**The HAVING clause allows use to filter the groups which are displayed. The WHERE clause filters rows before the aggregation, the HAVING clause filters after the aggregation.**
If a ORDER BY clause is included we can refer to columns by their position.

```<language>

SELECT continent, count(name)
FROM world
group by continent 
```


```<language>
SELECT continent, COUNT(name)
  FROM world
 WHERE population> 10000000
 GROUP BY continent
```

```<language>
SELECT continent
  FROM world
 GROUP BY continent
having sum(population) >= 100000000
```


## Join
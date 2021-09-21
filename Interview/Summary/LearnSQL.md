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

```<language>
SELECT SUM(GDP)
FROM world
where continent = 'Africa'
```

Give the total GDP of Africa

```<language>
SELECT sum(population)
FROM world
where name in  ('Estonia', 'Latvia', 'Lithuania')
```

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

You can combine the two steps into a single query with a JOIN.

```<language>
SELECT *
  FROM game JOIN goal ON (id=matchid)
```

The FROM clause says to merge data from the goal table with that from the game table. The ON says how to figure out which rows in game go with which rows in goal - the matchid from goal must match id from game. (If we wanted to be more clear/specific we could say
ON (game.id=goal.matchid)

```<language>

SELECT player, teamid, stadium, mdate
  FROM game JOIN goal ON (id=matchid)
where teamid = 'GER'
```

show the player, teamid, stadium and mdate for every German goal.

```<language>
SELECT team1, team2 , player
  FROM game JOIN goal ON (id=matchid)
where player like 'Mario%'
```
Show the team1, team2 and player for every goal scored by a player called Mario player LIKE 'Mario%'

```<language>
SELECT player, teamid, coach, gtime
  FROM goal JOIN eteam on teamid=id
 WHERE gtime<=10
```

Show player, teamid, coach, gtime for all goals scored in the first 10 minutes gtime<=10

```<language>
select mdate, teamname
from game join eteam on (team1=eteam.id)
where coach = 'Fernando Santos'
```

List the dates of the matches and the name of the team in which 'Fernando Santos' was the team1 coach.

```<language>
select player 
from game join goal on (game.id = goal.matchid)
where stadium = 'National Stadium, Warsaw'
```

List the player for every goal scored in a game where the stadium was 'National Stadium, Warsaw'

```<language>
SELECT DISTINCT(PLAYER)
  FROM game JOIN goal ON matchid = id 
    WHERE (team1='GER' or team2='GER') and teamid != 'GER'
```

Instead show the name of all players who scored a goal against Germany.

```<language>
SELECT teamname, COUNT(*)
  FROM eteam JOIN goal ON id=teamid
 GROUP BY teamname
```

Show teamname and the total number of goals scored.

```<language>
SELECT stadium, count(stadium)
FROM game JOIN goal ON id=matchid
group by stadium
```

Show the stadium and the number of goals scored in each stadium.

```<language>
SELECT id, mdate, count(id)
  FROM game JOIN goal ON matchid = id 
 WHERE (team1 = 'POL' OR team2 = 'POL')
group by id, mdate
```

For every match involving 'POL', show the matchid, date and the number of goals scored.

```<language>
SELECT *
  FROM game JOIN goal ON matchid = id 
 WHERE (teamid = 'POL' OR team2 = 'POL')
group by id, mdate
```
For every match where 'GER' scored, show matchid, match date and the number of goals scored by 'GER'

```<language>
SELECT mdate,
       team1,
       SUM(CASE WHEN teamid = team1 THEN 1 ELSE 0 END) AS score1,
       team2,
       SUM(CASE WHEN teamid = team2 THEN 1 ELSE 0 END) AS score2 FROM
    game left JOIN goal ON (id = matchid)
    GROUP BY mdate,team1,team2
    ORDER BY mdate, matchid, team1, team2
```

List every match with the goals scored by each team as shown. This will use "CASE WHEN" which has not been explained in any previous exercises.

group by multiple
https://stackoverflow.com/questions/2421388/using-group-by-on-multiple-columns


## More join operations

```<language>
SELECT id, title
 FROM movie
 WHERE yr=1962
```
List the films where the yr is 1962 [Show id, title]


```<language>
SELECT yr
 FROM movie
 WHERE title= 'Citizen Kane'
```

Give year of 'Citizen Kane'.


```<language>
SELECT id, title, yr 
 FROM movie
 WHERE title like 'Star Trek%'
order by yr
```

List all of the Star Trek movies, include the id, title and yr (all of these movies include the words Star Trek in the title). Order results by year.


```<language>
SELECT id
 FROM actor
 WHERE name = 'Glenn Close'
```

What id number does the actor 'Glenn Close' have?


```<language>
SELECT id
 FROM movie
 WHERE title = 'Casablanca'
```

What is the id of the film 'Casablanca'


```<language>
SELECT name
FROM
   movie JOIN casting ON movie.id= casting.movieid
         JOIN actor   ON casting.actorid=actor.id

  WHERE movieid =11768
```

Obtain the cast list for 'Casablanca'.


```<language>
SELECT name
FROM
   movie JOIN casting ON movie.id= casting.movieid
         JOIN actor   ON casting.actorid=actor.id

  WHERE title ='Alien'
```
Obtain the cast list for the film 'Alien'


```<language>
SELECT title
FROM
   movie JOIN casting ON movie.id= casting.movieid
         JOIN actor   ON casting.actorid=actor.id

where name = 'Harrison Ford'
```

List the films in which 'Harrison Ford' has appeared


```<language>
SELECT title
FROM
   movie JOIN casting ON movie.id= casting.movieid
         JOIN actor   ON casting.actorid=actor.id

where name = 'Harrison Ford' and ord != 1
```

List the films where 'Harrison Ford' has appeared - but not in the starring role. 


```<language>
SELECT title, name
FROM
   movie JOIN casting ON movie.id= casting.movieid
         JOIN actor   ON casting.actorid=actor.id
where yr = 1962 and ord = 1
```

List the films together with the leading star for all 1962 films.


```<language>
SELECT yr,COUNT(title) FROM
  movie JOIN casting ON movie.id=movieid
        JOIN actor   ON actorid=actor.id
WHERE name='Rock Hudson'
GROUP BY yr
HAVING COUNT(title) > 2
```

Which were the busiest years for 'Rock Hudson', show the year and the number of movies he made each year for any year in which he made more than 2 movies.


```<language>
SELECT title, name
  FROM movie, casting, actor
  WHERE movieid=movie.id
    AND actorid=actor.id
    AND ord=1
    AND movieid IN
    (SELECT movieid FROM casting, actor
     WHERE actorid=actor.id
     AND name='Julie Andrews')
```

List the film title and the leading actor for all of the films 'Julie Andrews' played in.


```<language>
SELECT name
    FROM casting JOIN actor
      ON  actorid = actor.id
    WHERE ord=1
GROUP BY name
    HAVING COUNT(movieid)>=15
```

Obtain a list, in alphabetical order, of actors who've had at least 15 starring roles.

```<language>
SELECT title, COUNT(actorid) AS actors FROM movie
JOIN casting ON id = movieid
WHERE yr = 1978
GROUP BY title
ORDER BY actors DESC,title
```

List the films released in the year 1978 ordered by the number of actors in the cast, then by title.


```<language>
select actor.name
from (
    select movieid from casting
    join actor on actor.id = casting.actorid 
        and actor.name = 'Art Garfunkel'
) ag_movies
join casting on ag_movies.movieid = casting.movieid
join actor on actor.id = casting.actorid 
    and actor.name != 'Art Garfunkel'
```

List all the people who have worked with 'Art Garfunkel'.

## using null
```<language>
select name from teacher
where dept is null
```

List the teachers who have NULL for their department.

```<language>
SELECT teacher.name, dept.name
 FROM teacher JOIN dept
           ON (teacher.dept=dept.id)
```

Note the INNER JOIN misses the teachers with no department and the departments with no teacher.



```<language>
SELECT teacher.name, dept.name
 FROM teacher left JOIN dept
           ON (teacher.dept=dept.id)
```
Use a different JOIN so that all teachers are listed.



```<language>
SELECT teacher.name, dept.name
 FROM teacher right JOIN dept
           ON (teacher.dept=dept.id)
```

Use a different JOIN so that all departments are listed.



```<language>

SELECT name, COALESCE(mobile, '07986 444 2266') as mobile 
 FROM teacher 
```

Use COALESCE to print the mobile number. Use the number '07986 444 2266' if there is no number given. Show teacher name and mobile number or '07986 444 2266'



```<language>
SELECT teacher.name, COALESCE(dept.name, 'None') as department 
 FROM teacher left JOIN dept
           ON (teacher.dept=dept.id)

```
Use the COALESCE function and a LEFT JOIN to print the teacher name and department name. Use the string 'None' where there is no department.


```<language>
SELECT count(name) as teachercnt, count(mobile) as mobilecnt
 FROM teacher 
```
Use COUNT to show the number of teachers and the number of mobile phones.


```<language>
SELECT dept.name, count(teacher.name)
 FROM teacher right JOIN dept
           ON (teacher.dept=dept.id)
group by(dept.name)
```


Use COUNT and GROUP BY dept.name to show each department and the number of staff. Use a RIGHT JOIN to ensure that the Engineering department is listed.


```<language>
SELECT name, CASE WHEN dept IN (1, 2) THEN 'Sci' ELSE 'Art' END FROM teacher;

```

Use CASE to show the name of each teacher followed by 'Sci' if the teacher is in dept 1 or 2 and 'Art' otherwise.


```<language>
SELECT name, 
CASE WHEN dept IN (1, 2) THEN 'Sci' 
     WHEN dept = 3 THEN 'Art'
     ELSE 'None' END 
FROM teacher;
```
Use CASE to show the name of each teacher followed by 'Sci' if the teacher is in dept 1 or 2, show 'Art' if the teacher's dept is 3 and 'None' otherwise.



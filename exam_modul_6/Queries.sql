# Query 1
select title from characteristics
order by title asc limit 5;

# Query 2
select from_user_id, to_user_id, accepted
from connections
where accepted = 1
and from_user_id = 481
order by to_user_id desc;

# Query 3
select username from users
inner join likes on user_id = likes.liked_user_id
group by user_id
order by count(likes.liked_user_id) desc, user_id desc limit 3;

# Query 4
select user_id, username, first_name, last_name from users
left join likes on user_id = likes.liked_user_id
where likes.liked_user_id is null
group by user_id
order by first_name, last_name desc limit 10;

# Query 5
select username from users
join characteristics_users cu on users.user_id = cu.user_id
where cu.characteristic_id = 3
and cu.value = "blue"
and users.birthdate between "1990-1-1" and "1999-12-31"
and gender = "f"
order by username desc;

# Query 6
select cast(avg(value) as decimal(10,2)) as average_height from characteristics_users
where characteristic_id = 1;

# Query 7
select u1.username as liked_by, u2.username as liked, cu1.value as liked_by_eye_color, cu2.value as liked_eye_color
from likes l
join users u1 on l.liked_by_user_id = u1.user_id
join users u2 on l.liked_user_id = u2.user_id
join characteristics_users cu1 on l.liked_by_user_id = cu1.user_id
join characteristics_users cu2 on l.liked_user_id = cu2.user_id
where cu1.characteristic_id = 3
and cu2.characteristic_id = 3
order by liked_by, liked limit 5
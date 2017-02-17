
<?php

echo "Enter the number of elements";


$number=read_stdin();
$n=$number;
$numbers[10];



echo "Enter the elements";
for($i=1; $i<=number; $i++)
{
	$numbers[$i]=read_stdin();
	
}

echo($numbers);

for($i=1; $i<=($number/2); $i++)
{
	$temp=$numbers[$n];
	$numbers[$i]=$numbers[$n];
	$numbers[$n]=$temp;
	$n--;
	
}
echo($numbers);




function read_stdin(){
	
	$give=fopen("php://stdin","r");
	$input=fgets($give,100);
	$input=rtrim($input);
	fclose($give);
	return $input;

}


?>

<?php

echo "Enter the number of elements";


$number=read_stdin();
$n=$number;
$numbers=array();



echo "Enter the elements\n";
for($i=0; $i<$number; $i++)
{
	array_push($numbers,read_stdin());
	
}



for($i=0; $i<($number/2); $i++)
{
	$temp=$numbers[$i];
	$numbers[$i]=$numbers[$n-1];
	$numbers[$n-1]=$temp;
	$n--;
	
}
echo "After Inversion\n";
for($i=0; $i<$number; $i++)
{
	echo($numbers[$i]."\n");
	
}





function read_stdin(){
	
	$give=fopen("php://stdin","r");
	$input=fgets($give,100);
	$input=rtrim($input);
	fclose($give);
	return $input;

}


?>
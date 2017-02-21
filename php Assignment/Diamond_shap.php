
<?php

echo "Enter Number of rows";

$number = read_stdin();
$n=$number;

$i=1;
while($i<=$number)
{
	for($j=1;$j<=$n/2;$j++)
	{
		echo " ";
		
	}
	for($l=1;$l<=$i;$l++){
		echo "*";
	}
	echo "\n";
	$i=$i+2;
	$n=$n-2;
	
}
$i=1;
$n=$number;
while($i<=$n)
{
	for($j=1;$j<=$i;$j++)
	{
		echo " ";
		
	}
	$number=$number-2;
	for($l=1;$l<=$number;$l++){
		echo "*";
	}
	echo "\n";
	$i=$i+1;
	
	
}


function read_stdin(){
	
	$give=fopen("php://stdin","r");
	$input=fgets($give,100);
	$input=rtrim($input);
	fclose($give);
	return $input;

}

?>
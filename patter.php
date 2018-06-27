$string = <<<'EOT'
<?php

namespace custom\aon\controllers;


/**
 * Account
 *
 * @uses   Toc
 * @uses   _controller
 * @author Mengshuai Zhu <mengshuai.zhu@ifchange.com>
 */
class Account extends \custom\base\controllers\Account
{


}


EOT;
$project_name ='test';
$pattern = '/\\aon\\/';
// $replacement = '(\\'.$project_name.'\\$)';
$replacement = '\test\\';
echo preg_replace($pattern,$replacement,$string);


http://www.atool.org/regex.php

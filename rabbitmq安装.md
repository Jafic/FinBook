1 
https://blog.csdn.net/qq_26718271/article/details/76577356#

��װ erlang �� rabbitmq


2 �汾ѡ��
https://www.rabbitmq.com/which-erlang.html

git�ϸ����汾��Ϣ ����Դ�뼰 ��ϵͳ����������� �� https://github.com/rabbitmq/rabbitmq-server/releases

3 rabbitmq 3.7.14  erlang 21.03



4 ����
The filename, directory name, or volume label syntax is incorrect.

�����
	��һ��
		Remove RabbitMQ and Erlang
		Remove registry entries under HKLM/SOFTWARE/Ericsson/Erlang/ErlSrv.
		Remove all .erlang.cookie (possibly in %HOMEDRIVE%%HOMEPATH% and %SYSTEMROOT%)
		Install Erlang then RabbitMQ WITH ADMIN USER.
		Make sure in system environment, ERLANG_HOME with C:\Program Files\erlyour version number exist. If not, create.
		Run rabbitmq-plugins enable rabbitmq_management from RabbitMQ sbin folder	
	�ڶ��� ����
	��3��
	
	https://stackoverflow.com/questions/38900125/windows-could-not-start-the-rabbitmq-service-on-local-computer
	��4�� �ο�
		https://github.com/rabbitmq/rabbitmq-server/issues/625
		
����ԭ���������װ ���沽�� ���Խ��
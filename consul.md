consul ��װ
consul ����
	��ʼ���ţ� https://www.consul.io/intro/index.html
	
����
	- consul agent -dev ������ʾ: ==> Starting Consul agent...
	==> Error starting agent: Failed to start Consul server: 
	Failed to start RPC layer: listen tcp 127.0.0.1:8300: bind: An attempt was made to access a socket in a way forbidden by its access permissions.

	�ο�����
		https://appuals.com/fix-an-attempt-was-made-to-access-a-socket-in-a-way-forbidden-by-its-access-permissions/

���⣺An attempt was made to access a socket in a way forbidden by its access permissions.
	�����������
	1 VPN client  ������ ��ֹ
	2 application is attempt open a port that is already used
		ʹ��  netstat ����  netstat -an [-p TCP]
	3 Windows 10 security feature
	4 Another process is listening on the desired port


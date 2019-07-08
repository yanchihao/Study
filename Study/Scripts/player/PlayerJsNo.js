var key = "12345678912345678912345678912345";
function showvideo(fileurl) {

	var videoUrl = Decrypt(fileurl, key);
	cyberplayer("playercontainer").setup({
		width: 680, // 宽度，也可以支持百分比(不过父元素宽度要有)
		height: 448, // 高度，也可以支持百分比
		title: "基本功能", // 标题
		file: videoUrl, // 播放地址
		image: "http://gcqq450f71eywn6bv7u.exp.bcevod.com/mda-hbqagik5sfq1jsai/mda-hbqagik5sfq1jsai.jpg", // 预览图
		autostart: false, // 是否自动播放
		stretching: "uniform", // 拉伸设置
		repeat: false, // 是否重复播放
		volume: 100, // 音量
		controls: true, // controlbar是否显示
		starttime: 0, // 视频开始播放时间点(单位s)，如果不设置，则可以从上次播放时间点续播
		logo: { // logo设置
			linktarget: "_blank",
			margin: 8,
			hide: false,
			position: "top-right", // 位置
			file: "/Content/picture.jpg" // 图片地址
		},
		ak: "f2ee596b6ddd4ac4bdf2a49526f0e2cd" // 公有云平台注册即可获得accessKey
	});
}

function Encrypt(source) {
	var keys = CryptoJS.enc.Utf8.parse(key);
	var iv = CryptoJS.enc.Utf8.parse("1234567890000000");
	var encrypted = '';
	var srcs = CryptoJS.enc.Utf8.parse(source);
	encrypted = CryptoJS.AES.encrypt(srcs, keys, {
		iv: iv,
		mode: CryptoJS.mode.CBC,
		padding: CryptoJS.pad.Pkcs7
	});

	return encrypted.ciphertext.toString();
}
function Decrypt(source) {
	var keys = CryptoJS.enc.Utf8.parse(key);
	var iv = CryptoJS.enc.Utf8.parse("1234567890000000");
	var encryptedHexStr = CryptoJS.enc.Hex.parse(source);
	var srcs = CryptoJS.enc.Base64.stringify(encryptedHexStr);
	var decrypt = CryptoJS.AES.decrypt(srcs, keys, {
		iv: iv,
		mode: CryptoJS.mode.CBC,
		padding: CryptoJS.pad.Pkcs7
	});
	var decryptedStr = decrypt.toString(CryptoJS.enc.Utf8);
	return decryptedStr.toString();
}
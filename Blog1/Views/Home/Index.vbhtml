@Code
    ViewData("Title") = "Home Page"
End Code
@*<div id="top">
    <ul>
        <li><a href="#">About</a></li>
        <li><a href="#">Submit a Story</a></li>
        <li><a href="#">Feedback</a></li>
        <li><a href="#">Support</a></li>
    </ul>
</div>*@
<!-- END TOP -->
<!-- BEGIN HEADER -->
    <div id="header">
        <div id="logo"> <a href="#"><img src="https://www.saigonpaper.com/uploads/blog/bannerweb-0212.jpg" alt="" , style="height: 100%; max-width :100% " /></a> </div>
        <div id="ad"> <img src="~/img/ad-blank.png" alt="" /> </div>
    </div>
<!-- END HEADER -->
<!-- BEGIN NAV -->
<div id="nav">
    <ul>
        <li><a href="#">Trang Chủ</a></li>
        <li><a href="#">Thời Sự</a></li>
        <li><a href="#">Thê giới</a></li>
        <li><a href="#">Kinh tế</a></li>
        <li><a href="#">Giáo dục</a></li>
        <li><a href="#">Xã hội</a></li>
        <li><a href="#">Pháp luật</a></li>
        <li><a href="#">Khoa học</a></li>
        <li><a href="#">Thể thao</a></li>


    </ul>
</div>
<!-- END NAV -->
<!-- BEGIN SUB NAV -->
<div id="sub-nav">
    @*<ul>
        <li class="title">Stay in the know:</li>
        <li><a href="#">Blogs</a></li>
        <li>|</li>
        <li><a href="#">Video Gallery</a></li>
        <li>|</li>
        <li><img src="~/img/icons/rss.png" alt="" /><a href="#">Subscribe</a></li>
        <li>|</li>
        <li><img src="~/img/icons/twitter.png" alt="" /><a href="#">Twitter</a></li>
    </ul>*@
    <div id="time">
        <script>
            function thoigian() {
                var time = new Date();
                var gio = time.getHours();
                var phut = time.getMinutes();
                var giay = time.getSeconds();
                if (gio < 10)
                    gio = "0" + gio;
                if (phut < 10)
                    phut = "0" + phut;
                if (giay < 10)
                    giay = "0" + giay;
                document.getElementById("time").innerHTML = gio + ":" + phut + ":" + giay + " (GMT +7)";
                setTimeout("thoigian()", 1000);
            }
            thoigian();

        </script>       
    </div>


</div>
<!-- END SUB NAV -->
<!-- BEGIN CONTENT WRAPPER -->
<div id="content-wrapper">
    <!-- BEGIN MAIN -->
    <div id="main">
        <div id="headlines">
            <div id="main-headline">
                <h2 class="heading">Kinh tế</h2>
                <img src="https://cdnmedia.baotintuc.vn/Upload/xWDHf0fP0gRVbF1yzOohA/files/2020/04/1204-evn.jpg" alt="" />
                <h1><a href="#">Vì sao hóa đơn tiền điện tăng cao?.</a></h1>
                <p class="author"><span>10.06.2020</span></p>
                <p>Tại Hà Nội mấy ngày gần đây, nhiều khách hàng ở huyện Gia Lâm, Đông Anh và quận Hai Bà Trưng, Thanh Xuân phản ánh, hóa đơn tiền điện tháng 5 và 6 tăng cao. Khách hàng bày tỏ nghi ngại có sự nhầm lẫn trong tính tiền điện.</p>
                <p><a href="#">Xem chi tiết &raquo;</a></p>
                <h2 class="heading">Chính trị</h2>
                <img src="https://cdnmedia.baotintuc.vn/Upload/DmtgOUlHWBO5POIHzIwr1A/files/2020/06/14/quoc-hoi-140620.jpg" alt="" />
                <h1><a href="#">Tuần làm việc từ ngày 15-19/6: Quốc hội quyết định nhiều vấn đề quan trọng</a></h1>
                <p class="author"><span>10.06.2020</span></p>
                <p>Trong tuần làm việc cuối cùng của Kỳ họp thứ 9 (từ ngày 15-19/6), Quốc hội thảo luận và quyết ....</p>
                <p><a href="#">Xem chi tiết &raquo;</a></p>
            </div>
            <div id="more-headlines">
                <h2 class="heading">Tin Tức nổi bật</h2>

                <h2><a href="#">Tròn 59 ngày Việt Nam không có ca mắc mới COVID-19 do lây nhiễm trong cộng đồng</a></h2>
                <p class="author"><span>14.06.2020</span></p>
                <p>Từ 6 giờ đến 18 giờ ngày 14/6, Việt Nam tiếp tục không ghi nhận ca mắc mới COVID-19, giữ nguyên tổng số 334 ca mắc..</p>
                <p><a href="#">Xem chi tiết &raquo;</a></p>

                <h3><a href="#">Mưa lũ làm sập cầu, nhiều cánh đồng bị ngập sâu tại Lào Cai</a></h3>
                <p class="author"><span>10.06.2020</span></p>
                <p>Trận mưa lớn đã gây ra lũ làm thiệt hại nhiều diện tích lúa, hoa màu và các công trình giao thông trên địa bàn tỉnh Lào Cai..</p>
                <p><a href="#">Xem chi tiết &raquo;</a></p>

                <h3><a href="#">Bắc Bộ, Bắc Trung Bộ mưa dông, cục bộ có mưa to đến rất to từ chiều 14/6 đến ngày 15/6</a></h3>
                <p class="author"><span>10.06.2020</span></p>
                <p>Theo Trung tâm Dự báo Khí tượng Thủy văn Quốc gia, do ảnh hưởng của rãnh áp thấp qua Bắc Bộ nối với vùng áp thấp suy yếu từ bão số 1 kết hợp với vùng hội tụ gió lên đến mực 5.000m...</p>
                <p><a href="#">Xem chi tiết &raquo;</a></p>

                <h2 class="heading">Podcast</h2>
                <img src="~/img/microphone.png" alt="" class="righty" />
                <h4><a href="#">Lorem ipsum dolor sit amet, consectetur</a></h4>
                <p class="author"><span>10.06.2020</span></p>
                <p>Ut sed arcu nulla. In eget lectus vitae purus volutpat consectetur suscipit ut justo.</p>
                <p><a href="#">More podcasts &raquo;</a></p>
            </div>
        </div>
    </div>

    <div id="sidebars">

        <a href="#"><img src="~/img/side-ad.png" alt="" class="ad" /></a> <a href="#"><img src="~/img/side-ad.png" alt="" class="ad-right" /></a> <a href="#"><img src="img/side-ad.png" alt="" class="ad" /></a> <a href="#"><img src="img/side-ad.png" alt="" class="ad-right" /></a>

        <h2 class="heading-blue">Thể Thao</h2>
        <img src="~/img/14062020realmadrid1.jpg" alt="" , class="ad"/>
        <h3><a href="#">Real Madrid - Eibar: Mệnh lệnh phải thắng.</a></h3>
        <p>Trước việc Barca đại thắng, Real Madrid chắc chắn sẽ phải cháy hết mình ở trận đấu rạng sáng mai ...</p>
        <p class="author"><span>10.06.2020</span></p>
        <p><a href="#">Xem chi tiết &raquo;</a></p>

        <h2 class="heading">Xã hội</h2>
        <img src="https://cdnmedia.baotintuc.vn/Upload/ekaE01yuAw3S4G2j0Rtmuw/files/2020/06/chitrachodoituonglaodongtudo070620.jpg" alt="" class="ad" />
        <h3><a href="#">Chi trả hỗ trợ lao động mất việc do dịch COVID-19 tại Hà Nội triển khai chậm.</a></h3>
        <p class="author"><span>10.06.2020</span></p>
        <p>Công tác chi trả hỗ trợ cho các nhóm đối tượng lao động, hộ kinh doanh và người sử dụng lao động gặp khó khăn do ảnh hưởng của đại dịch COVID-19 theo gói 62.000 tỷ đồng tại TP Hà Nội chậm triển khai.</p>
        <p><a href="#">Xem chi tiết &raquo;</a></p>

        <h2 class="heading">In the Community</h2>
        <h4><a href="#">Lorem ipsum dolor sit amet eget, consectetur adipiscing elit</a></h4>
        <h4><a href="#">Lorem ipsum dolor sit amet eget, consectetur adipiscing elit</a></h4>
    </div>
</div>

<div id="extras">
    <div id="recommended">
        <h2 class="heading">Recommended Stories</h2>
        <ul>
            <li><a href="#">Lorem ipsum dolor sit amet, consectetur adipiscing elit &raquo;</a></li>
            <li><a href="#">Lorem ipsum dolor sit amet, consectetur adipiscing elit &raquo;</a></li>
            <li><a href="#">Lorem ipsum dolor sit amet, consectetur adipiscing elit &raquo;</a></li>
            <li class="last"><a href="#">Lorem ipsum dolor sit amet, consectetur adipiscing elit &raquo;</a></li>
        </ul>
    </div>
    <div id="programs">
        <h2 class="heading">What's On Tonight</h2>
        <img src="~/img/rick.jpg" alt="" /> <img src="~/img/cbc.png" alt="" />
    </div>
    <div id="cartoon">
        <h2 class="heading">Humour</h2>
        <img src="~/img/cartoon.jpg" alt="" />
    </div>
</div>

<div id="footer">
    <ul>
        <li><p>&copy; @DateTime.Now.Year -  <a href="https://www.facebook.com/Namcoii2302">Nam Còii</a></li>
    </ul>
</div>
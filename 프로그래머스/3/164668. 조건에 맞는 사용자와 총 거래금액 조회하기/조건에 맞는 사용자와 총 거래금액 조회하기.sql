-- 코드를 입력하세요
SELECT USER_ID,NICKNAME, SUM(IF(STATUS='DONE',PRICE,0)) AS TOTAL_SALES
FROM USED_GOODS_BOARD
LEFT JOIN USED_GOODS_USER 
ON USED_GOODS_BOARD.WRITER_ID=USED_GOODS_USER.USER_ID
GROUP BY WRITER_ID
HAVING TOTAL_SALES >= 700000
ORDER BY TOTAL_SALES ASC
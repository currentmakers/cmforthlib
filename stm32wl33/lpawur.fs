\
\ @file lpawur.fs
\ @brief LPAWUR interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief FRAME_CONFIG0 register
\ Address offset: 0x00
\ Reset value: 0x02074012
\

$000000ff constant LPAWUR_FRAME_CONFIG0_PREAMBLE_THRESHOLD_COUNT    \ The number of transitions for preamble detection when receiving the manchester encoded preamble.
$00000100 constant LPAWUR_FRAME_CONFIG0_SYNC_LENGTH                 \ Frame sync pattern length ( Manchester encoded ).
$0000fc00 constant LPAWUR_FRAME_CONFIG0_SYNC_THRESHOLD_COUNT        \ detection threshold when receivng the Frame sync ( Manchester encoded).
$000f0000 constant LPAWUR_FRAME_CONFIG0_PAYLOAD_LENGTH              \ The number of data Bytes in the payload ( decoded ).
$03e00000 constant LPAWUR_FRAME_CONFIG0_SLOW_CLK_CYCLE_PER_BIT_CNT    \ The number of expected slow clock cycle per each manchester coded bit.


\
\ @brief FRAME_CONFIG1 register
\ Address offset: 0x04
\ Reset value: 0x00024669
\

$0000000f constant LPAWUR_FRAME_CONFIG1_KI                          \ ki gain value for the timing recovery loop.
$000000f0 constant LPAWUR_FRAME_CONFIG1_KP                          \ kp gain value for the timing recovery loop.
$0000ff00 constant LPAWUR_FRAME_CONFIG1_FRAME_SYNC_COUNTER_TIMEOUT    \ The timeout in manchester encoded bits for the Frame Sync,it represents the number of samples after which in case the frame sync is not detected a sync_error is raised.
$00020000 constant LPAWUR_FRAME_CONFIG1_PREAMBLE_ENABLE             \ Preamble detection enable
$00040000 constant LPAWUR_FRAME_CONFIG1_TREC_LOOP_ALGO_SEL          \ Timing recovery loop algorithm selection:


\
\ @brief FRAME_SYNC_CONFIG register
\ Address offset: 0x08
\ Reset value: 0x00009696
\

$0000ffff constant LPAWUR_FRAME_SYNC_CONFIG_FRAME_SYNC_PATTERN_L    \ The value of the frame sync pattern, Low word, manchester encoded, used when the frame sync length is 16 bit (default 0x9696 which represent a frame sync value of 0x99)
$ffff0000 constant LPAWUR_FRAME_SYNC_CONFIG_FRAME_SYNC_PATTERN_H    \ The value of the frame sync pattern, High word, manchester encoded, used only when the frame sync length is 32 bits (default 0x0000 )


\
\ @brief RFIP_CONFIG register
\ Address offset: 0x0C
\ Reset value: 0x00000006
\

$00000001 constant LPAWUR_RFIP_CONFIG_LPAWUR_ENABLE                 \ Enable (start) or Disable (stop) the LPAWUR feature (0: disabled by default)
$00000006 constant LPAWUR_RFIP_CONFIG_WAKEUP_LEVEL                  \ - 00: the bit Sync has been detected


\
\ @brief RF_CONFIG register
\ Address offset: 0x10
\ Reset value: 0x000133EE
\

$00000001 constant LPAWUR_RF_CONFIG_ED_SWITCH                       \ - 0 : Normal operation (default)
$0000001e constant LPAWUR_RF_CONFIG_CLKDIV                          \ Calibrate 4kHz clock (programmable divider)
$00001800 constant LPAWUR_RF_CONFIG_AGC_LOW_LVL                     \ AGC level (Low) (default value: 0x2)
$00002000 constant LPAWUR_RF_CONFIG_ED_DC_CTRL                      \ DC current subtraction enabling signal (default value: 0x1)
$0003c000 constant LPAWUR_RF_CONFIG_AGC_HIGH_LVL                    \ AGC level (High) (default value: 0x4)
$001c0000 constant LPAWUR_RF_CONFIG_ED_ICAL                         \ Current versus VBAT calibration for ED
$00200000 constant LPAWUR_RF_CONFIG_LPF3_CAL                    


\
\ @brief AGC_CONFIG register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000003 constant LPAWUR_AGC_CONFIG_AGC_MODE                       \ Define the working mode of the AGC:
$00000004 constant LPAWUR_AGC_CONFIG_AGC_HOLD_MODE                  \ The behavior when the AGC is ON and is working in HOLD mode
$00000008 constant LPAWUR_AGC_CONFIG_AGC_RESET_MODE                 \ The AGC reset behavior when the AGC is working in ON or HOLD mode


\
\ @brief PAYLOAD_0 register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant LPAWUR_PAYLOAD_0_PAYLOAD_0                       \ First part of the payload (Least significant Byte First)


\
\ @brief PAYLOAD_1 register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant LPAWUR_PAYLOAD_1_PAYLOAD_1                       \ Second part of the payload (Least significant Byte First)


\
\ @brief LPAWUR interrupt
\
$49001000 constant LPAWUR_FRAME_CONFIG0  \ offset: 0x00 : FRAME_CONFIG0 register
$49001004 constant LPAWUR_FRAME_CONFIG1  \ offset: 0x04 : FRAME_CONFIG1 register
$49001008 constant LPAWUR_FRAME_SYNC_CONFIG  \ offset: 0x08 : FRAME_SYNC_CONFIG register
$4900100c constant LPAWUR_RFIP_CONFIG  \ offset: 0x0C : RFIP_CONFIG register
$49001010 constant LPAWUR_RF_CONFIG  \ offset: 0x10 : RF_CONFIG register
$49001014 constant LPAWUR_AGC_CONFIG  \ offset: 0x14 : AGC_CONFIG register
$4900101c constant LPAWUR_PAYLOAD_0  \ offset: 0x1C : PAYLOAD_0 register
$49001020 constant LPAWUR_PAYLOAD_1  \ offset: 0x20 : PAYLOAD_1 register


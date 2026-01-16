\
\ @file iwdg.fs
\ @brief IWDG_KR register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief IWDG_KR register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000ffff constant IWDG_IWDG_KR_KEY                                 \ Key value. Software can only write these bits. Reading returns the reset value. These bits must be written by software at regular intervals with the key value 0xAAAA, otherwise the watchdog generates a reset when the counter reaches 0. Writing the key value 0x5555 to enables access to the IWDG_PR, IWDG_RLR and IWDG_WINR registers. Writing the key value CCCCh starts the watchdog


\
\ @brief IWDG_PR register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000007 constant IWDG_IWDG_PR_PR                                  \ Prescaler divider. Set and reset by software. These bits are write access protected. They are written by software to select the prescaler divider feeding the counter clock. PVU bit of IWDG_SR must be reset in order to be able to change the prescaler divider. 000: divider/4 001: divider/8 010: divider/16 011: divider/32 100: divider/64 101: divider/128 110: divider/256 111: divider/256


\
\ @brief IWDG_RLR register
\ Address offset: 0x08
\ Reset value: 0x00000FFF
\

$00000fff constant IWDG_IWDG_RLR_RL                                 \ Watchdog counter reload value. Set and reset by software. These bits are write access protected. They are written by software to define the value to be loaded in the watchdog counter each time the value 0xAAAA is written in the IWDG_KR register. The watchdog counter counts down from this value. The timeout period is a function of this value and the clock prescaler. The RVU bit in the IWDG_SR register must be reset in order to be able to change the reload value.


\
\ @brief IWDG_SR register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant IWDG_IWDG_SR_PVU                                 \ Watchdog prescaler value update. Read only bit. This bit is set by hardware to indicate that an update of the prescaler value is ongoing. It is reset by hardware when the prescaler update operation is completed in the VDD voltage domain (takes up to 5 RC 40 kHz cycles). Prescaler value can be updated only when PVU bit is reset
$00000002 constant IWDG_IWDG_SR_RVU                                 \ Watchdog counter reload value update. Read only bit. This bit is set by hardware to indicate that an update of the reload value is ongoing. It is reset by hardware when the reload value update operation is completed in the VDD voltage domain (takes up to 5 RC 40 kHz cycles). Reload value can be updated only when RVU bit is reset
$00000004 constant IWDG_IWDG_SR_WVU                                 \ Watchdog counter window value update. Read only bit. This bit is set by hardware to indicate that an update of the window value is ongoing. It is reset by hardware when the reload value update operation is completed in the VDD voltage domain (takes up to 5 RC 40 kHz cycles). Window value can be updated only when WVU bit is reset. This bit is generated only if generic 'window' = 1


\
\ @brief IWDG_WINR register
\ Address offset: 0x10
\ Reset value: 0x00000FFF
\

$00000fff constant IWDG_IWDG_WINR_WIN                               \ Watchdog counter window value. Set and reset by software. These bits are write access protected. These bits contain the high limit of the window value to be compared to the downcounter. To prevent a reset, the downcounter must be reloaded when its value is lower than the window register value and greater than 0x0 The WVU bit in the IWDG_SR register must be reset in order to be able to change the reload value.


\
\ @brief IWDG_KR register
\
$40003000 constant IWDG_IWDG_KR   \ offset: 0x00 : IWDG_KR register
$40003004 constant IWDG_IWDG_PR   \ offset: 0x04 : IWDG_PR register
$40003008 constant IWDG_IWDG_RLR  \ offset: 0x08 : IWDG_RLR register
$4000300c constant IWDG_IWDG_SR   \ offset: 0x0C : IWDG_SR register
$40003010 constant IWDG_IWDG_WINR  \ offset: 0x10 : IWDG_WINR register

